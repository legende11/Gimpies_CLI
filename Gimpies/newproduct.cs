using System;

namespace Gimpies
{
    public class newproduct
    {
        public static void newProduct()
        {
            string merk = question.InputString("Wat is het merk?");
            string type = question.InputString("Welke schoen is het?");
            double maat = question.Inputdob("Wat is de maat?");
            string kleur = question.InputString("Wat is de kleur?");
            int aantal = question.InputNum("Hoeveel schoenen zijn er");
            double prijs = question.Inputdob("Hoeveel kost de schoen? (In euro's)");
            char uid = char.Parse((Program.products.Count + 1).ToString());
            Product p = new Product(merk, type, maat, kleur, aantal, prijs, uid);
            Program.products.Add(p);
            Product.sort();
            Program.Menu();
        }
    }
}