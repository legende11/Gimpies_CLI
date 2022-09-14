using System.Windows.Forms;
using Gimpies;

namespace Gimpies_form;

public partial class manager_aanpassen : Form
{
    private Product saveproduct;
    public manager_aanpassen()
    {
        InitializeComponent();
    }

    

    private void load_but_Click(object sender, EventArgs e)
    {
        try
        {
            saveproduct = Product.getproduct(Convert.ToInt32(product.Text));
            merk.Text = saveproduct.Merk;
            type.Text = saveproduct.Type;
            maat.Text = Convert.ToString(saveproduct.Maat);
            kleur.Text = saveproduct.Kleur;
            //Aantal.Text = Convert.ToString(saveproduct.Aantal);
            Prijs.Text = Convert.ToString(saveproduct.Prijs);


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

    private void save_but_Click(object sender, EventArgs e)
    {
        try
        {
            Product NewProduct = new Product(merk.Text, type.Text, Convert.ToDouble(maat.Text), kleur.Text, saveproduct.Aantal, Convert.ToDouble(Prijs.Text), saveproduct.Uid);
            Product.StaticUpdate(saveproduct, NewProduct);
            Close();

        }
        catch (Exception)
        {
            merk.Text = "Error";
            type.Text = "Input";
            maat.Text = "Verkeerd";
            kleur.Text = "";
            //Aantal.Text = "";
            Prijs.Text = "";
        }

    }
}