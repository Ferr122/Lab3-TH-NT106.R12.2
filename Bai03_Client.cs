using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab3_25521671
{
    public partial class Bai03_Client : Form
    {
        public Bai03_Client()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient tcpClient = new TcpClient();
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
                tcpClient.Connect(ipEndPoint);
                NetworkStream ns = tcpClient.GetStream();
                byte[] data = Encoding.ASCII.GetBytes("Hello server\r\n");
                ns.Write(data, 0, data.Length);
                ns.Close();
                tcpClient.Close();
                MessageBox.Show("Đã gửi thông điệp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối đến Server: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
