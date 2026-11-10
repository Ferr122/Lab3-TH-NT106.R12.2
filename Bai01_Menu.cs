namespace Lab3_25521671
{
    public partial class Bai01_Menu : Form
    {
        public Bai01_Menu()
        {
            InitializeComponent();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            Bai01_Server serverForm = new Bai01_Server();
            serverForm.Show();
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            Bai01_Client clientForm = new Bai01_Client();
            clientForm.Show();
        }
    }
}
