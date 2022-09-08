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
            type = question.InputString("Welke schoen is het?");
            maat = question.Inputdob("Wat is de maat?");
            kleur = question.InputString("Wat is de kleur?");
            aantal = question.InputNum("Hoeveel schoenen zijn er");
            prijs = question.Inputdob("Hoeveel kost de schoen? (In euro's)");
            uid = char.Parse((Program.products.Count + 1).ToString());
            Product p = new Product(merk, type, maat, kleur, aantal, prijs, uid);
            Program.products.Add(p);
            Product.sort();
            Program.Menu();
        }
    }
}