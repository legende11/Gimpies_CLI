using System;

namespace Gimpies
{
    public class inkopen
    {
        public static void Editor()
        {
            Program.products = database.getproducts(); // update products
            Console.Clear();
            Console.WriteLine("Inkoop");
            Console.WriteLine("[0] Terug naar menu");
            foreach (var product in Program.products)
            {
                Console.WriteLine(
                    $"[{product.Uid}] Aantal {product.Aantal} Van {product.Merk} {product.Type} met de maat {product.Maat} voor de prijs van {product.Prijs}");
            }

            String k = Console.ReadLine();
            foreach (var p in Program.products)
            {
                if (k == "0")
                {
                    Program.Menu();
                    return;
                }
                if (p.Uid.ToString() == k)
                {
                    EditorMenu(p);
                    return;
                }
            }

            Editor();
        }

        // this is the submenu of the edit submenu where the edit is passed through
        static void EditorMenu(Product product)
        {
            Console.Clear();
            Console.WriteLine("Wat wil je aanpassen?");
            Console.WriteLine("[A] Merk");
            Console.WriteLine("[B] Naam");
            Console.WriteLine("[C] Maat");
            Console.WriteLine("[D] Kleur");
            Console.WriteLine("[E] Voorraad");
            Console.WriteLine("[F] Prijs");
            Char k = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (k)
            {
                // these will generate new products with the supplied information & swap them out in the map
                case 'a':
                    String merk = question.InputString("Wat is het nieuwe merk?");
                    Product merkp = new Product(merk, product.Type, product.Maat, product.Kleur, product.Aantal,
                        product.Prijs, product.Uid);
                    product.UpdateProduct(product, merkp);
                    break;

                case 'b':
                    String naam = question.InputString("Wat is de nieuwe naam?");
                    Product naamp = new Product(product.Merk, naam, product.Maat, product.Kleur, product.Aantal,
                        product.Prijs, product.Uid);
                    product.UpdateProduct(product, naamp);
                    break;
                case 'c':
                    double maat = question.Inputdob("Wat is de nieuwe maat?");
                    Product maatp = new Product(product.Merk, product.Type, maat, product.Kleur, product.Aantal,
                        product.Prijs, product.Uid);
                    product.UpdateProduct(product, maatp);
                    break;
                case 'd':
                    string kleur = question.InputString("Wat is de nieuwe kleur?");
                    Product kleurp = new Product(product.Merk, product.Type, product.Maat, kleur, product.Aantal,
                        product.Prijs, product.Uid);
                    product.UpdateProduct(product, kleurp);
                    break;
                case 'e':
                    int voorraad = question.InputNum("Hoeveel is er ingekocht?");
                    Product voorraadp = new Product(product.Merk, product.Type, product.Maat, product.Kleur,
                        voorraad + product.Aantal, product.Prijs, product.Uid);
                    product.UpdateProduct(product, voorraadp);
                    break;
                case 'f':
                    double prijs = question.Inputdob("Wat is de nieuwe prijs?");
                    Product prijsp = new Product(product.Merk, product.Type, product.Maat, product.Kleur,
                        product.Aantal, prijs, product.Uid);
                    product.UpdateProduct(product, prijsp);
                    break;
                default:
                    Editor();
                    break;
            }

            // your done, open the menu.
            Console.Clear();
            Program.Menu();
        }
    }
}