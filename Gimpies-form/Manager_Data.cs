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
    public partial class Manager_Data : Form
    {
        public Manager_Data()
        {
            InitializeComponent();
        }

        private void Manager_Data_Load(object sender, EventArgs e)
        {
            double duurste = 0;
            int meeste = 0;
            double gemiddeld = 0;
            double totaal = 0;
            List<Product> products = database.getproducts();
            foreach (Product product in products)
            {
                if (product.Prijs > duurste)
                {
                    duurste = product.Prijs;
                }
                if (product.Aantal > meeste)
                {
                    meeste = product.Aantal;
                }

                gemiddeld += product.Prijs;
                totaal += product.Aantal * product.Prijs;
            }

            gemiddeld /= products.Count;

            String text = $"Duurste schoen: {duurste}\nMeeste voorraad: {meeste}\nGemiddelde prijs: {gemiddeld}\nTotale waarde: {totaal}";
            txt_left.Text = text;

            int rtotaal = 0;
            string rmeestestr = "";
            string rminstestr = "";
            int rmeesteint = 0;
            int rminsteint = 10;
            int totaleomzet = 0;
            foreach (Product product in products)
            {
                int aantal = database.getaantal(product.Uid);
                rtotaal += aantal;
                if (rmeesteint < aantal)
                {
                    rmeesteint = aantal;
                    rmeestestr = product.Type;
                }
                if (rminsteint > aantal)
                {
                    rminsteint = aantal;
                    rminstestr = product.Type;
                }
                totaleomzet = (int)(aantal * product.Prijs);
            }



            String right = $"Totaal verkocht: {rtotaal}\nMeest verkocht: {rmeestestr}\nMinst verkocht: {rminstestr}\nTotale omzet: {totaleomzet}";
            txt_right.Text = right;
        }
    }
}