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
        private static char uid;
        public static void newProduct()
        {
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
            uid = char.Parse((Program.products.Count + 1).ToString());
            Product p = new Product(merk, type, maat, kleur, aantal, prijs, uid);
            Program.products.Add(p);
            Product.sort();
            Program.Menu();
        }
    }
}