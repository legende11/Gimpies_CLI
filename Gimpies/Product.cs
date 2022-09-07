using System.Collections.Generic;
using System.Linq;

namespace Gimpies
{
    public class Product
    {
        public string Merk;
        public string Type;
        public double Maat;
        public string Kleur;
        public int Aantal;
        public double Prijs;
        public char Uid;

        public Product(string merk, string type, double maat, string kleur, int aantal, double prijs, char uid)
        {
            Merk = merk;
            Type = type;
            Maat = maat;
            Kleur = kleur;
            Aantal = aantal;
            Prijs = prijs;
            Uid = uid;
        }

        // best way to get products for now
        public static List<Product> GenerateProducts()
        {
            //TODO: Get a way to save the list to a file and read it on startup. this makes it that changes exist between sessions
            List<Product> Products = new List<Product>();

            Products.Add(new Product("Nike", "Air max", 32, "Zwart", 16, 120.00, '1'));
            Products.Add(new Product("Adidas", "Schoenen", 33, "Wit", 12, 126.90, '2'));
            Products.Add(new Product("Scapino", "Schoenen", 45, "Oranje & Blauw", 12, 9, '3'));
            Products.Add(new Product("Nike", "Air max 1", 32, "Zwart", 16, 120.00, '4'));
            return Products;
        }

        // update the products in the map by deleting the old one
        public void UpdateProduct(Product oldproduct, Product newproduct)
        {
            Program.products.Remove(oldproduct);
            Program.products.Add(newproduct);
            sort(); // sort it so that the view products is ready once again
        }

        public static void sort()
        {
            // temporarily create a new list
            List<Product> tmpproducts = new List<Product>();
            // sort the old list and push them to new list
            foreach (var VARIABLE in Program.products.OrderBy(x => int.Parse(x.Uid.ToString())))
            {
                // add product to tmp array
                tmpproducts.Add(VARIABLE);
            }

            // oldlist -> newlist
            Program.products = tmpproducts;
        }
    }
}