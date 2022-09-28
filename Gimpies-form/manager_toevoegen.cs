using System.Reflection;
using System.Windows.Forms;
using Gimpies;

namespace Gimpies_form;

public partial class manager_toevoegen : Form
{
    public manager_toevoegen()
    {
        InitializeComponent();
        merk.Text = "Merk schoen";
        type.Text = "Type schoen";
        maat.Text = "Maat schoen";
        kleur.Text = "Schoen kleur";
        //Aantal.Text = "Aantal schoenen";
        Prijs.Text = "Prijs schoenen";
    }

    private void save_but_Click(object sender, EventArgs e)
    {
        try
        {
            if (Product.exists(merk.Text, type.Text, Convert.ToDouble(maat.Text), kleur.Text))
            {
                merk.Text = "Product";
                type.Text = "Bestaat";
                maat.Text = "Al";
                kleur.Text = "";
                //Aantal.Text = "";
                Prijs.Text = "";
                return;
            }
            if (TypeBestaat(type.Text))
            {
                merk.Text = "Type";
                type.Text = "Bestaat";
                maat.Text = "Al";
                kleur.Text = "";
                //Aantal.Text = "";
                Prijs.Text = "";
                return;
            }
            
            
            char uid = (Product.products.Count + 1).ToString().ToCharArray()[0];
            Product NewProduct = new Product(merk.Text, type.Text, Convert.ToDouble(maat.Text), kleur.Text, 0, Convert.ToDouble(Prijs.Text), uid);
            Product.products.Add(NewProduct);
            new database().SaveProducts(NewProduct);
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
    
    private bool TypeBestaat(string TYPE)
    {
        foreach (Product product in Product.products)
        {
            if (product.Type == TYPE)
            {
                return true;
            }
        }
        return false;
    }

    private void Prijs_TextChanged(object sender, EventArgs e)
    {
    }


    private void kleur_TextChanged(object sender, EventArgs e)
    {
    }

    private void maat_TextChanged(object sender, EventArgs e)
    {
    }

    private void type_TextChanged(object sender, EventArgs e)
    {
    }

    private void merk_TextChanged(object sender, EventArgs e)
    {
    }
}