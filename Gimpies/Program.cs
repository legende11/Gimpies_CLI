using System;
using System.Collections.Generic;

namespace Gimpies
{
    internal static class Program
    {
        private const String Username = "Inkoop";
        private const String Password = "Gimpies_Inkoop";
        public static List<Product> products = Product.GenerateProducts();
        private static Boolean loggedin;
        private static Int16 tries;
        
        static void Main()
        {
            Console.Title = "Gimpies";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            loggedin = false;
            tries = 1;
            Console.Clear();

            while (tries <= 3 && !loggedin)
            {
                if (Login())
                {
                    loggedin = true;
                    Console.Clear();
                    Console.WriteLine("Inloggen gelukt");
                    Menu();
                    return;
                }
                else
                {
                    Console.Clear();
                    tries++;
                    Console.WriteLine($"Username of wachtwoord is verkeerd. pogingen resterend {4 - tries}");
                }
            }
        }

        static Boolean Login()
        {
            String username = question.InputString("Username:");
            if (username == "exit")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("Wachtwoord:");
            string password = null;
            while
                (true) // https://stackoverflow.com/questions/23433980/c-sharp-console-hide-the-input-from-console-window-while-typing
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
                Console.Write('*');
            }

            if (username == Username && password == Password)
            {
                return true;
            }

            return false;
        }

        // main menu where you select all the submenu's
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("_-_menu_-_");
            Console.WriteLine("[A] Voorraad schoenen bekijken");
            Console.WriteLine("[B] Schoenen inkopen");
            Console.WriteLine("[C] Nieuw product");
            Console.WriteLine("[D] Verkoop product");
            Console.WriteLine("[E] Bestellingen");

            Console.WriteLine("[F] Uitloggen");
            char key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case 'a':
                    voorraad();
                    return;
                case 'b':
                    inkopen.Editor();
                    return;
                case 'c':
                    newproduct.newProduct();
                    return;
                case 'd':
                    verkoop.Menu();
                    return;
                case 'e':
                    bestellingen.Menu();
                    return;
                case 'f':
                    Console.Clear();
                    Main();
                    return;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        // stock submenu
        static void voorraad()
        {
            Console.Clear();
            Console.WriteLine("Voorraad");
            foreach (var product in products)
            {
                Console.WriteLine(
                    $"[{product.Uid}] Aantal {product.Aantal} Van {product.Kleur} {product.Merk} {product.Type} met de maat {product.Maat} voor de prijs van {product.Prijs}");
            }
            
            Console.WriteLine("Druk op een knop om terug te gaan naar het menu.");

            Console.ReadKey();
            Menu();
        }
    }
}