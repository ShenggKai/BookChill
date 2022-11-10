namespace BookChill
{
    public partial class Login : Form
    {
        private string myUser = "Kai";
        private string myPass = "1234";

        public Login()
        {
            InitializeComponent();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == myUser && txtPass.Text == myPass)
            {
                new BookChill().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The username or password you entered incorrect, please try again!");
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }
    }
}