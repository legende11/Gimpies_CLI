using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gimpies;

namespace Gimpies_form
{
    public partial class users : Form
    {
        private database db = new database();
        public users()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            usercl cl = database.GetUser(Int32.Parse(inpID.Text));
            username.Text = cl.username;
            password.Text = cl.password;
            id.Text = cl.rank.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            database.updateUser(Int32.Parse(inpID.Text), username.Text, password.Text, Int32.Parse(id.Text));
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (database.GetUser(Convert.ToInt32(inpID.Text)).username == Form1.USERNAME)
            {
                return;
            }
            db.deleteUser(Convert.ToInt32(inpID.Text));
        }

        private void NEW_Click(object sender, EventArgs e)
        {
            db.NewUser(username.Text, password.Text, Int32.Parse(id.Text));
        }
    }
}
