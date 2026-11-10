namespace Lab3_25521671
{
    public partial class Bai04_Menu : Form
    {
        public Bai04_Menu()
        {
            InitializeComponent();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            Bai04_Server serverForm = new Bai04_Server();
            serverForm.Show();
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            Bai04_Client clientForm = new Bai04_Client();
            clientForm.Show();
        }
    }
}
