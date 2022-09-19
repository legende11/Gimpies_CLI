using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Gimpies;

public class database
{
    private static readonly string constring =
        "Data Source=DESKTOP-TJJ8LR1\\SQLEXPRESS;Initial Catalog=gimpies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    public static SqlConnection Connection = new SqlConnection(constring);


    public static Dictionary<string, string> getVerkoop()
    {
        using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\" WHERE TypeUser = 1;", Connection))
        {
            Dictionary<string, string> Logins = new Dictionary<string, string>();
            Logins.Clear();
            Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // Check is the reader has any rows at all before starting to read.
                if (!reader.HasRows)
                    return Logins;
                // Read advances to the next row.
                while (reader.Read())
                {
                    Logins.Add(reader.GetString(reader.GetOrdinal("nameUser")), reader.GetString(reader.GetOrdinal("passUser")));
                }
                Connection.Close();
                return Logins;
            }
        }
    }


    public static Dictionary<string, string> GetAdmin()
    {
        using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\" WHERE TypeUser = 2;", Connection))
        {
            Dictionary<string, string> Logins = new Dictionary<string, string>();
            Logins.Clear();
            Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // Check is the reader has any rows at all before starting to read.
                if (!reader.HasRows)
                    return Logins;
                // Read advances to the next row.
                while (reader.Read())
                {
                    Logins.Add(reader.GetString(reader.GetOrdinal("nameUser")), reader.GetString(reader.GetOrdinal("passUser")));
                }
                Connection.Close();
                return Logins;
            }
        }
    }


    public static Dictionary<string, string> GetInkoop()
    {
        using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\" WHERE TypeUser = 0;", Connection))
        {
            Dictionary<string, string> Logins = new Dictionary<string, string>();
            Logins.Clear();
            Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // Check is the reader has any rows at all before starting to read.
                if (!reader.HasRows)
                    return Logins;
                // Read advances to the next row.
                while (reader.Read())
                {
                    Logins.Add(reader.GetString(reader.GetOrdinal("nameUser")), reader.GetString(reader.GetOrdinal("passUser")));
                }
                Connection.Close();
                return Logins;
            }
        }
    }


    public static List<Product> getproducts()
    {
        List<Product> products = new List<Product>();


        using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"product\";", Connection))
        {
            Connection.Close();
            Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // Check is the reader has any rows at all before starting to read.
                if (!reader.HasRows)
                    return products;
                // Read advances to the next row.
                while (reader.Read())
                {
                    Product p = new Product(reader.GetString(reader.GetOrdinal("brand")), reader.GetString(reader.GetOrdinal("type")),
                        reader.GetDouble(reader.GetOrdinal("size")), reader.GetString(reader.GetOrdinal("color")), reader.GetInt32(reader.GetOrdinal("aantal")),
                        reader.GetDouble(reader.GetOrdinal("price")), reader.GetInt32(reader.GetOrdinal("id")));
                    products.Add(p);
                }
                Connection.Close();
            }
        }

        return products;
    }

    public static void SaveProducts(Product product)
    {
        Connection.Close();

        {
            String query =
                "set identity_insert product off; INSERT INTO product (brand, type, size, color, price, aantal) VALUES (@brand, @type, @size, @color, @price, @aantal); set identity_insert product on;";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@brand", product.Merk);
                command.Parameters.AddWithValue("@type", product.Type);
                command.Parameters.AddWithValue("@size", product.Maat);
                command.Parameters.AddWithValue("@color", product.Kleur);
                command.Parameters.AddWithValue("@price", product.Prijs);
                command.Parameters.AddWithValue("@aantal", product.Aantal);

                Connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
        }

        Program.products = database.getproducts();
    }

    public static void updateProduct(int id, Product product)
    {
        Connection.Close();

        {
            String query = "UPDATE product SET brand = @brand, type = @type, color = @color, price = @price, aantal = @aantal WHERE id = @id;";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@brand", product.Merk);
                command.Parameters.AddWithValue("@type", product.Type);
                command.Parameters.AddWithValue("@size", product.Maat);
                command.Parameters.AddWithValue("@color", product.Kleur);
                command.Parameters.AddWithValue("@price", product.Prijs);
                command.Parameters.AddWithValue("@aantal", product.Aantal);

                Connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
        }
    }

    public static int getrank(string username)
    {
        using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\";", Connection))
        {
            Dictionary<string, string> Logins = new Dictionary<string, string>();
            Logins.Clear();
            Connection.Close();
            Connection.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // Check is the reader has any rows at all before starting to read.
                if (!reader.HasRows)
                {
                    Connection.Close();
                    return -1;
                }

                // Read advances to the next row.
                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("nameUser")) == username)
                    {
                        return reader.GetInt32(reader.GetOrdinal("TypeUser"));
                    }
                }
                Connection.Close();
                return -1;
            }
        }
        return -1;
    }

    public void DeleteProdut(int id)
    {
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
            String query = "DELETE FROM product WHERE id = @id; ";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@id", id);


                Connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
        }
        // DELETE FROM table_name WHERE condition; 
    }


    public static void Saveorder(Product product, int amount)
    {
        Connection.Close();

        {
            String query = "set identity_insert product off; INSERT INTO orders (product, amount, sold) VALUES (@product, @amount, @sold); set identity_insert product on;";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@product", product.Uid);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@sold", 0);

                Connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
        }

        Program.products = database.getproducts();
    }

    public static void updateorder(int id)
    {
        Connection.Close();

        {
            String query = "UPDATE orders SET sold = @sold WHERE id = @id;";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@sold", 1);

                Connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
        }
        getorders();
    }

    public static Dictionary<int, bestelling> getorders()
    {
        Dictionary<int, bestelling> array = new Dictionary<int, bestelling>();

        using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"orders\";", Connection))
        {
            Connection.Close();
            Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // Check is the reader has any rows at all before starting to read.
                if (!reader.HasRows)
                    return array;
                // Read advances to the next row.
                while (reader.Read())
                {
                    bestelling o = new bestelling(Product.getproduct(reader.GetInt32(reader.GetOrdinal("product"))),
                        Convert.ToBoolean(reader.GetInt32(reader.GetOrdinal("sold"))), reader.GetInt32(reader.GetOrdinal("amount")));
                    array.Add(reader.GetInt32(reader.GetOrdinal("id")), o);
                }
                Connection.Close();
            }
        }

        bestellingen.array = array;
        return array;
    }

    public static bool CheckLogin(string username, string password)
    {
        using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\";", Connection))
        {
            Dictionary<string, string> Logins = new Dictionary<string, string>();
            Logins.Clear();
            Connection.Close();
            Connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // Check is the reader has any rows at all before starting to read.
                if (!reader.HasRows)
                {
                    return false;
                }
                // Read advances to the next row.
                while (reader.Read())
                {
                    Logins.Add(reader.GetString(reader.GetOrdinal("nameUser")), reader.GetString(reader.GetOrdinal("passUser")));
                }
                Connection.Close();

                try
                {
                    return Logins[username] == password;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}