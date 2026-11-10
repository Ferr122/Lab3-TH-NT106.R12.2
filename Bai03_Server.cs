using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_25521671
{
    public partial class Bai03_Server : Form
    {
        private Socket serverSocket;
        private Thread listenThread;
        private bool isListening = false;

        public Bai03_Server()
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
                    serverSocket.Listen(10);

                    isListening = true;
                    btnListen.Text = "Stop";

                    if (txtLog != null)
                    {
                        txtLog.AppendText("Server đã sẵn sàng\r\n");
                    }

                    listenThread = new Thread(new ThreadStart(AcceptClientConnections));
                    listenThread.IsBackground = true;
                    listenThread.Start();
                }
                catch (Exception ex)
                {
                    isListening = false;
                    MessageBox.Show("Lỗi khởi động Server: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Thread clientThread = new Thread(() => ReceiveDataFromClient(clientSocket));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
            }
            catch
            {
               
            }
        }

        private void ReceiveDataFromClient(Socket clientSocket)
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (isListening)
                {
                    int bytesReceived = clientSocket.Receive(buffer);
                    if (bytesReceived == 0) break;
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                    if (!this.IsDisposed && this.IsHandleCreated)
                    {
                        this.Invoke(new Action(() =>
                        {
                            if (txtLog != null)
                            {
                                txtLog.AppendText(message); 
                            }
                        }));
                    }
                }
            }
            catch
            {
                
            }
            finally
            {
                try { clientSocket.Close(); } catch { }
            }
        }

        private void StopServer()
        {
            isListening = false;
            try
            {
                serverSocket?.Close();
            }
            catch { }

            if (!this.IsDisposed && this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    btnListen.Text = "Listen";
                    if (txtLog != null)
                    {
                        txtLog.AppendText("Server đã dừng.\r\n");
                    }
                }));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
        }
    }
}
