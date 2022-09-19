using System;

namespace Gimpies
{
    public class newproduct
    {
        private static string merk;
        private static string type;
        private static double maat;
        private static string kleur;
        private static int aantal;
        private static double prijs;
        private static int uid;
        public static void newProduct()
        {
            Program.products = database.getproducts(); // update products
            merk = question.InputString("Wat is het merk?");
            Console.Clear();
            type = question.InputString("Welke schoen is het?");
            Console.Clear();
            maat = question.Inputdob("Wat is de maat?");
            Console.Clear();
            kleur = question.InputString("Wat is de kleur?");
            Console.Clear();
            aantal = question.InputNum("Hoeveel schoenen zijn er");
            Console.Clear();
            prijs = question.Inputdob("Hoeveel kost de schoen? (In euro's)");
            Console.Clear();
            uid = Program.products.Count + 1;
            Product p = new Product(merk, type, maat, kleur, aantal, prijs, uid);
            database.SaveProducts(p);
            //Program.products.Add(p);
            Program.products = database.getproducts();
            Product.sort();
            Program.Menu();
        }
    }
}