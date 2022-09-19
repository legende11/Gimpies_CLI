using Gimpies;

namespace Gimpies_form
{
    public partial class Form1 : Form
    {
        private int tries = 3;
        private database DB = new database();
        public Form1()
        {
            tries = 3;
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
            Tries.Text = $"Pogingen resterend: {tries}";
            if (tries == 0)
            {
                this.Close();
            }
        }

        public void Reset()
        {
            // reset the default values and show the login page again
            username_b.Text = "";
            password.Text = "";
            tries = 3;
            this.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            bool login = DB.CheckLogin(username_b.Text, password.Text);
            if (login)
            {
                if (DB.getrank(username_b.Text) == 1)
                {
                    this.Hide();
                    Form verkoop = new VerkoopMain();
                    verkoop.ShowDialog();
                    Reset();
                }
                else if (DB.getrank(username_b.Text) == 2)
                {
                    this.Hide();
                    Form Manager = new ManagerMain();
                    Manager.ShowDialog();
                    Reset();
                }
            }
            else
            {
                FailedAttempt();
            }
        }
    }
}