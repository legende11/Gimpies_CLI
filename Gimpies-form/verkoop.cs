using System.Windows.Forms;
using Gimpies;

namespace Gimpies_form;

public partial class verkoop : Form
{
    public verkoop()
    {
        InitializeComponent();
        ERROR.Text = "";
    }

    private void verkoop_but_Click(object sender, EventArgs e)
    {
        try
        {
            Product p = Product.getproduct(Convert.ToInt32(product_inp.Text));
            int aantal = Convert.ToInt32(aantal_inp.Text);
            if (p.Aantal - aantal >= 0)
            {
                
                Product.StaticUpdate(p, new Product(p.Merk, p.Type, p.Maat, p.Kleur, p.Aantal - aantal, p.Prijs, p.Uid), aantal);
                ERROR.Text = $"Success: Product {p.Type} is verkocht";
            }
            else
            {
                ERROR.Text = "Error: Niet genoeg producten op voorraad";
            }
        }
        catch (Exception ex)
        {
            ERROR.Text = "Error: product updaten niet gelukt: " + ex;
        }
    }

    private void producten_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form voorraad = new voorraad();
        voorraad.ShowDialog();
        this.Show();
    }
}