using Gimpies;

namespace Gimpies_form;

public partial class voorraad : Form
{
    public voorraad()
    {
        InitializeComponent();
        vorraad.Text = "Voorraad:";
        foreach (Product product in Product.products)
        {
            vorraad.Text +=
                $"ID: {product.Uid} Merk: {product.Merk} Type: ${product.Type} Maat: {product.Maat} Kleur: {product.Kleur} Aantal: {product.Aantal} Prijs: {product.Prijs}\n";
        }
    }

    private void back_Click(object sender, EventArgs e)
    {
        Close();
    }
}