using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lab3_25521671
{
    public partial class Bai01_Client : Form
    {
        public Bai01_Client()
        {
            InitializeComponent();
        }

        private void btnSend_click_Click(object sender, EventArgs e)
        {
            try
            {
                string ServerIPStr = txtServerIP.Text.Trim();
                int ServerPort = int.Parse(txtServerPort.Text.Trim());
                string message = txtMessage.Text;
                if (string.IsNullOrEmpty(ServerIPStr))
                {
                    MessageBox.Show("Vui lòng nhập IP Remote host!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                IPAddress ServerIP = IPAddress.Parse(ServerIPStr);
                IPEndPoint iPEndPoint = new IPEndPoint(ServerIP, ServerPort);
                using (UdpClient udpClient = new UdpClient())
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    udpClient.Send(data, data.Length, iPEndPoint);
                }
                MessageBox.Show("Đã gửi thông điệp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi thông điệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
