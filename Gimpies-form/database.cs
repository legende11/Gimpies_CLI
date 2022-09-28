using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Gimpies_form;
using Microsoft.VisualBasic.ApplicationServices;

namespace Gimpies;

public class database
{
    private static readonly string constring =
        "Data Source=DESKTOP-TJJ8LR1\\SQLEXPRESS;Initial Catalog=gimpies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    public static SqlConnection Connection = new SqlConnection(constring);


    public Dictionary<string, string> getVerkoop()


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


    public Dictionary<string, string> GetAdmin()
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


    public Dictionary<string, string> GetInkoop()
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

    public void SaveProducts(Product product)
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

        Product.products = database.getproducts();
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

    public static void updateProduct(int id, Product product)
    {
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
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

    public int getrank(string username)
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

    public bool CheckLogin(string username, string password)
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
    
        public void NewUser(string username, string password, int rank)
    {
        Connection.Close();

        {
            String query =
                "set identity_insert product off; INSERT INTO login (nameUser, passUser, TypeUser) VALUES (@username, @password, @id); set identity_insert product on;";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id", rank);

                Connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
        }

        Product.products = database.getproducts();
    }

        
        public usercl getuser(int id)
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
                        return new usercl(-1, "Error", "Error", -1);
                    }
                    // Read advances to the next row.
                    while (reader.Read())
                    {
                        if (reader.GetInt32(reader.GetOrdinal("id")) == id)
                        {
                            return new usercl(reader.GetInt32(reader.GetOrdinal("id")), reader.GetString(reader.GetOrdinal("nameUser")), reader.GetString(reader.GetOrdinal("passUser")),
                                reader.GetInt32(reader.GetOrdinal("TypeUser")));
                        }
                        // Logins.Add(reader.GetString(reader.GetOrdinal("nameUser")), reader.GetString(reader.GetOrdinal("passUser")));
                    }
                    return new usercl(-1, "Error", "Error", -1);

                    Connection.Close();


                }
                
            }
        }

    public void deleteUser(int id)
    {
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
            String query = "DELETE FROM login WHERE id = @id; ";

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

    public static void updateUser(int id, string username, string password, int typeuser)
    {
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
            String query = "UPDATE login SET nameUser = @nameUser, passUser = @passUser, TypeUser = @typeuser WHERE id = @id;";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nameUser", username);
                command.Parameters.AddWithValue("@passUser", password);
                command.Parameters.AddWithValue("@typeuser", typeuser);

                Connection.Open();
                int result = command.ExecuteNonQuery();

                // Check Error
                if (result < 0)
                    Console.WriteLine("Error inserting data into Database!");
            }
        }
    }
    
}