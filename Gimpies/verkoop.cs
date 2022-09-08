using System;

namespace Gimpies
{
    public class verkoop
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Verkoop");
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
                if (p.Uid.ToString() != k)
                {
                    continue;
                }
                Product.StaticUpdate(p, new Product(p.Merk, p.Type, p.Maat, p.Kleur, p.Aantal-1, p.Prijs, p.Uid));
                Program.Menu();
                return;
            }
            Program.Menu();
        }
    }
}