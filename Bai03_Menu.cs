namespace Lab3_25521671
{
    public partial class Bai03_Menu : Form
    {
        public Bai03_Menu()
        {
            InitializeComponent();
        }

        private void btnOpenServer_Click(object sender, EventArgs e)
        {
            Bai03_Server serverForm = new Bai03_Server();
            serverForm.Show();
        }

        private void btnOpenClient_Click(object sender, EventArgs e)
        {
            Bai03_Client clientForm = new Bai03_Client();
            clientForm.Show();
        }
    }
}
