using System.Net.Sockets;
using System.Text;

namespace Lab3_25521671
{
    public partial class Bai04_Client : Form
    {
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private Thread receiveThread;
        public Bai04_Client()
        {
            InitializeComponent();
            ConnectToServer();
        }
        private void ConnectToServer()
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", 8080);
                networkStream = tcpClient.GetStream();
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối Server: " + ex.Message);
            }
        }
        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (true)
                {
                    int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    this.Invoke(new Action(() =>
                    {
                        txtLog.AppendText(message);
                    }));
                }
            }
            catch
            {

            }

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string msg = txtMessage.Text.Trim();
                string fullMessage = $"{name}: {msg}";
                byte[] data = Encoding.UTF8.GetBytes(fullMessage);
                networkStream.Write(data, 0, data.Length);
                networkStream.Flush();
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi tin nhắn: " + ex.Message);
            }
        }
        private void ChatClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                networkStream?.Close();
                tcpClient?.Close();
            }
            catch { }
        }
    }
}
