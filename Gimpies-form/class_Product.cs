using Gimpies_form;

namespace Gimpies;

public class Product
{
    public string Merk;
    public string Type;
    public double Maat;
    public string Kleur;
    public int Aantal;
    public double Prijs;
    public int Uid;
    public static List<Product> products = database.getproducts();

    public Product(string merk, string type, double maat, string kleur, int aantal, double prijs, int uid)
    {
        Merk = merk;
        Type = type;
        Maat = maat;
        Kleur = kleur;
        Aantal = aantal;
        Prijs = prijs;
        Uid = uid;
    }

    public void cout()
    {
        Console.WriteLine($"Merk {Merk}\n Type {Type}\n  Maat {Maat}\n   Kleur {Kleur}\n    Aantal {Aantal}\n     prijs {Prijs}\n      Uid {Uid}");
    }

    public static bool exists(string merk, string type, double maat, string kleur)
    {
        foreach (Product product in products)
        {
            if (product.Merk == merk && product.Type == type && product.Maat == maat && product.Kleur == kleur)
            {
                return true;
            }
        }
        return false;
    }

    // update the products in the map by deleting the old one
    public static void StaticUpdate(Product oldproduct, Product newproduct, int verkocht)
    {
        database.updateProduct(oldproduct.Uid, newproduct, verkocht);
        products.Remove(oldproduct);
        products.Add(newproduct);
        sort(); // sort it so that the view products is ready once again
    }
    public static Product getproduct(int id)
    {
        foreach (var p in products)
        {
            if (int.Parse(p.Uid.ToString()) == id)
            {
                return p;
            }
        }
        throw new InvalidOperationException();
    }

    static void sort()
    {
        // temporarily create a new list
        List<Product> tmpproducts = new List<Product>();
        // sort the old list and push them to new list
        foreach (var VARIABLE in products.OrderBy(x => int.Parse(x.Uid.ToString())))
        {
            // add product to tmp array
            tmpproducts.Add(VARIABLE);
        }

        // oldlist -> newlist
        products = tmpproducts;
    }
}