using System;
using System.Collections.Generic;

namespace Gimpies
{
    public class bestelling
    {
        public Product product;
        public bool gekocht;
        public int aantal;
        public bestelling(Product P, bool Gekocht, int Aantal)
        {
            product = P;
            gekocht = Gekocht;
            aantal = Aantal;
        }
    }

    public class bestellingen
    {
        public static Dictionary<int, bestelling> array = database.getorders();
        private static void nieuwe()
        {
            Console.Clear();
            Console.WriteLine("Nieuwe bestelling opgeven");
            int productID = question.InputNum("Product nummer?");
            int aantal = question.InputNum("Hoeveel van dit product is bestelt.");
            database.Saveorder(Product.getproduct(productID), aantal);
            array = database.getorders();
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("[A] Ga terug");
            Console.WriteLine("[B] Nieuwe bestelling");
            Console.WriteLine("[c] Bestellingen");

            switch (Console.ReadKey().KeyChar)
            {
                case 'a':
                    Program.Menu();
                    break;
                case 'b':
                    nieuwe();
                    break;
                case 'c':
                    verkoop();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        private static void verkoop()
        {
            Console.Clear();
            Console.WriteLine("Bestelling versturen.");
            foreach (KeyValuePair<int, bestelling> KeyPair in array)
            {
                String behandelt = "Die nog niet is behandelt";
                if (KeyPair.Value.gekocht)
                {
                    behandelt = "Die al is behandelt";
                }
                Console.WriteLine(
                    $"[{KeyPair.Key}] Product: ${KeyPair.Value.product.Merk} {KeyPair.Value.product.Type} Met Systeem id {KeyPair.Value.product.Uid} heeft een bestelling van {KeyPair.Value.aantal} product {behandelt}");
            }
            String line = Console.ReadLine();
            if (!String.IsNullOrEmpty(line))
            {
                int k = int.Parse(line);
                try
                {
                    array[k] = new bestelling(array[k].product, true, array[k].aantal);
                    database.updateorder(k);
                    Menu();
                }
                catch (Exception)
                {
                    Menu();
                }
                Menu();
            }
            Menu();
        }
    }
}