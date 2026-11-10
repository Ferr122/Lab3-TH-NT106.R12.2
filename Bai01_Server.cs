using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_25521671
{
    public partial class Bai01_Server : Form
    {
        private UdpClient udpServer;
        private Thread listenThread;
        private bool isListening = false;

        public Bai01_Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click_1(object sender, EventArgs e)
        {
            if (!isListening)
            {
                try
                {
                    int port = int.Parse(txtPort.Text.Trim());
                    udpServer = new UdpClient(port);
                    isListening = true;
                    btnListen.Text = "Stop";
                    txtPort.Enabled = false;
                    listenThread = new Thread(new ThreadStart(ReceiveData));
                    listenThread.IsBackground = true;
                    listenThread.Start();

                    AppendLog("Server đã bắt đầu lắng nghe trên cổng " + port);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi khởi động Server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                StopServer();
            }
        }
        private void ReceiveData()
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (isListening)
            {
                try
                {
                    byte[] data = udpServer.Receive(ref remoteEndPoint);
                    string message = Encoding.UTF8.GetString(data);

                    string logMessage = $"{remoteEndPoint.Address}:{message}";
                    this.Invoke(new Action(() =>
                    {
                        AppendLog(logMessage);
                    }));
                }
                catch (SocketException)
                {
                    break;
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
        private void AppendLog(string message)
        {
            txtLog.AppendText(message + Environment.NewLine);
        }
        private void StopServer()
        {
            isListening = false;
            try
            {
                udpServer?.Close();
            }
            catch { }
            btnListen.Text = "Listen";
            txtPort.Enabled = true;
            AppendLog("Server đã dừng.");
        }
    }
}
