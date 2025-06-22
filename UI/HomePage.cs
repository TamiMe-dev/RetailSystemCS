namespace UI
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void signInEmployee_Click(object sender, EventArgs e)
        {
            MenuEmployee menu = new MenuEmployee();
            this.Hide();
            menu.FormClosed += Menu_FormClosed;
            menu.Show();
        }

        private void signInManager_Click(object sender, EventArgs e)
        {
            MenuManager menu = new MenuManager();
            this.Hide();
            menu.FormClosed += Menu_FormClosed;
            menu.Show();
        }

    }
}


