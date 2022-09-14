using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimpies_form
{
    public partial class VerkoopMain : Form
    {
        public VerkoopMain()
        {
            InitializeComponent();
        }

        private void Voorraad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form voorraad = new voorraad();
            voorraad.ShowDialog();
            this.Show();
        }

        private void Verkopen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form verkoop = new verkoop();
            verkoop.ShowDialog();
            this.Show();
        }

        private void Uitloggen_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
