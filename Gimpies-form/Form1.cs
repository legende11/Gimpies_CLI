namespace Gimpies_form
{
    public partial class Form1 : Form
    {
        private int tries = 3;
        public Form1()
        {
            InitializeComponent();
            password.Text = "";
            // The password character is an asterisk.
            password.PasswordChar = '*';
            // The control will allow no more than 20 characters.
            password.MaxLength = 20;
        }

        private void username_b_TextChanged(object sender, EventArgs e)
        {

        }


        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void FailedAttempt()
        {
            tries--;
            Tries.Text = $"Pogingen resterent: {tries}";
            if (tries == 0)
            {
                this.Close();
            }
        }
        
        private void Reset()
        {
            // reset the default values and show the login page again
            username_b.Text = "";
            password.Text = "";
            tries = 3;
            this.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            switch(username_b.Text)
            {
                case "Verkoop":
                    if(password.Text == "Gimpies_Verkoop")
                    {
                        this.Hide();
                        Form verkoop = new VerkoopMain();
                        verkoop.ShowDialog();
                        Reset();
                    } else
                    {
                        FailedAttempt();
                    }
                    break;

                case "Admin":
                    if (password.Text == "Gimpies_Admin")
                    {
                        this.Hide();
                        Form Manager = new ManagerMain();
                        Manager.ShowDialog();
                        Reset();
                    } else
                    {
                        FailedAttempt();
                    }
                    break;
                default:
                    FailedAttempt();
                    break;
            }
        }
    }
}