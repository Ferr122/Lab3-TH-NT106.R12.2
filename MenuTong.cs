namespace Lab3_25521671
{
    public partial class MenuTong : Form
    {
        public MenuTong()
        {
            InitializeComponent();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            new Bai01_Menu().Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            new Bai02().Show();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            new Bai03_Menu().Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            new Bai04_Menu().Show();
        }
    }
}
