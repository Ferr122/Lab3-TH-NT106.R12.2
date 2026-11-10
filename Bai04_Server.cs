using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_25521671
{
    public partial class Bai04_Server : Form
    {
        private Socket serverSocket;
        private Thread listenThread;
        private bool isListening = false;
        private static List<Socket> clientList = new List<Socket>();

        public Bai04_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click_1(object sender, EventArgs e)
        {
            if (!isListening)
            {
                try
                {
                    int port = 8080;
                    serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);
                    serverSocket.Bind(endPoint);
                    serverSocket.Listen(100);
                    isListening = true;
                    btnListen.Text = "Stop";
                    if (txtLog != null)
                    {
                        txtLog.AppendText($"Server running on 127.0.0.1:{port}\r\n");
                    }
                    listenThread = new Thread(new ThreadStart(AcceptClientConnections));
                    listenThread.IsBackground = true;
                    listenThread.Start();
                }
                catch (Exception ex)
                {
                    isListening = false;
                    MessageBox.Show("Lỗi Server: " + ex.Message);
                }
            }
            else
            {
                StopServer();
            }
        }
        private void AcceptClientConnections()
        {
            try
            {
                while (isListening)
                {
                    Socket clientSocket = serverSocket.Accept();

                    lock (clientList)
                    {
                        clientList.Add(clientSocket);
                    }
                    string clientEndPoint = clientSocket.RemoteEndPoint.ToString();
                    this.Invoke(new Action(() =>
                    {
                        txtLog.AppendText($"New client connected from: {clientEndPoint}\r\n");
                    }));
                    Thread clientThread = new Thread(() => ReceiveAndBroadcast(clientSocket));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch { }
        }

        private void ReceiveAndBroadcast(Socket clientSocket)
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (isListening)
                {
                    int bytesReceived = clientSocket.Receive(buffer);
                    if (bytesReceived == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesReceived);
                    this.Invoke(new Action(() =>
                    {
                        txtLog.AppendText(message + "\r\n");
                    }));
                    lock (clientList)
                    {
                        foreach (var client in clientList)
                        {
                            try
                            {
                                client.Send(Encoding.UTF8.GetBytes(message + "\r\n"));
                            }
                            catch { }
                        }
                    }
                }
            }
            catch { }
            finally
            {
                lock (clientList)
                {
                    clientList.Remove(clientSocket);
                }
                try { clientSocket.Close(); } catch { }
            }
        }
        private void StopServer()
        {
            isListening = false;
            try { serverSocket?.Close(); } catch { }
            btnListen.Text = "Listen";
        }
    }
}
