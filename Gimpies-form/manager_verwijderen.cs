using System.Windows.Forms;
using Gimpies;

namespace Gimpies_form;

public partial class manager_verwijderen : Form
{
    private bool loaded = false;
    private Product saveproduct;
    public manager_verwijderen()
    {
        InitializeComponent();
        annuleer.Hide();
        loaded = false;
    }



    private void main_but_Click(object sender, EventArgs e)
    {
        if (!loaded)
        {
            main_but.Text = "Load";
            try
            {
                saveproduct = Product.getproduct(Convert.ToInt32(product.Text));
                merk.Text = saveproduct.Merk;
                type.Text = saveproduct.Type;
                maat.Text = Convert.ToString(saveproduct.Maat);
                kleur.Text = saveproduct.Kleur;
                //Aantal.Text = Convert.ToString(saveproduct.Aantal);
                Prijs.Text = Convert.ToString(saveproduct.Prijs);
                loaded = true;
                main_but.Text = "Delete?";
                annuleer.Show();

            }
            catch (Exception)
            {
                merk.Text = "Error";
                type.Text = "";
                maat.Text = "";
                kleur.Text = "";
                //Aantal.Text = "";
                Prijs.Text = "";
            }
        }
        else
        {
            Product.products.Remove(saveproduct);
            Close();
        }
    }

    private void annuleer_Click(object sender, EventArgs e)
    {
        Close();
    }
}