﻿using System.Windows.Forms;
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
            Product.products.Remove(saveproduct); // remove it from the array as it gets put back once you save
            if (Product.exists(merk.Text, type.Text, Convert.ToDouble(maat.Text), kleur.Text))
            {
                merk.Text = "Product";
                maat.Text = "Al";
                kleur.Text = "";
                //Aantal.Text = "";
                Prijs.Text = "";
                return;
            }

            if (TypeBestaat(type.Text) && type.Text != saveproduct.Type)
            {
                merk.Text = "Type";
                maat.Text = "Al";
                kleur.Text = "";
                //Aantal.Text = "";
                Prijs.Text = "";
                return;
            }
            Product NewProduct = new Product(merk.Text, type.Text, Convert.ToDouble(maat.Text), kleur.Text, saveproduct.Aantal, Convert.ToDouble(Prijs.Text), saveproduct.Uid);
            Product.StaticUpdate(saveproduct, NewProduct, 0);
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
}