using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace GimpiesApi;

public class database
{
    private static readonly string constring =
        "Data Source=DESKTOP-TJJ8LR1\\SQLEXPRESS;Initial Catalog=gimpies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    private static SqlConnection Connection = new SqlConnection(constring);

   

    public class products
    {
        public class Product
        {
            public string Merk;
            public string Type;
            public double Maat;
            public string Kleur;
            public int Aantal;
            public double Prijs;
            public int Uid;

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
        }
        
        
        public static bool UpdateProduct(int id, int aantal)
        {
            List<Product> products = GetProducts();
            int first = 0;
            first = products.FirstOrDefault(x => x.Uid == id).Aantal;
            if (first - aantal < 0)
            {
                return false;
            }
            Connection.Close();
            {
                String query = "UPDATE product SET aantal = @aantal WHERE id = @id;";

                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@aantal",first - aantal);

                    Connection.Open();
                    int result = command.ExecuteNonQuery();
                    // Check Error
                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into Database!");
                        return false;
                    } else {
                        return true;
                    }

                }
                return false;
            }
        }

        public static List<Product> GetProducts()
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
        
        public static Product GetProduct(int uid)
        {


            using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"product\" WHERE id = @id;", Connection))
            {
                Connection.Close();
                cmd.Parameters.AddWithValue("@id", uid);
                Connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (!reader.HasRows)
                        return new Product("", "", 0, "", 0, 0, 0);
                    // Read advances to the next row.
                    while (reader.Read())
                    {
                        Product p = new Product(reader.GetString(reader.GetOrdinal("brand")), reader.GetString(reader.GetOrdinal("type")),
                            reader.GetDouble(reader.GetOrdinal("size")), reader.GetString(reader.GetOrdinal("color")), reader.GetInt32(reader.GetOrdinal("aantal")),
                            reader.GetDouble(reader.GetOrdinal("price")), reader.GetInt32(reader.GetOrdinal("id")));
                       Connection.Close();
                       return p;
                    }
                    Connection.Close();
                }
            }

            return new Product("", "", 0, "", 0, 0, -1);
        }
    }

    public class OrderDB
    {
        public class order
        {
            public int id;
            public int customerid;
            public string productbrand;
            public string productname;
            public double productsize;
            public int amount;
            public order(int id, int customerid, string productbrand, string productname, double productsize, int amount)
            {
                this.id = id;
                this.customerid = customerid;
                this.productbrand = productbrand;
                this.productname = productname;
                this.productsize = productsize;
                this.amount = amount;
            }
        }
        
        
        public static List<order> GetOrders(int userid)
        {
            List<order> orders = new List<order>();


            using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"customer_orders\" WHERE customerid = @userid;", Connection))
            {
                cmd.Parameters.AddWithValue("@userid", userid);
                Connection.Close();
                Connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (!reader.HasRows)
                        return orders;
                    // Read advances to the next row.
                    while (reader.Read())
                    {
                        order o = new order(reader.GetInt32(reader.GetOrdinal("id")), reader.GetInt32(reader.GetOrdinal("customerid")), reader.GetString(reader.GetOrdinal("productbrand")), reader.GetString(reader.GetOrdinal("productname")), reader.GetDouble(reader.GetOrdinal("productsize")), reader.GetInt32((reader.GetOrdinal(("Amount")))));
                        orders.Add(o);
                    }
                    Connection.Close();
                }
            }

            return orders;
        }

        public static bool NewOrder(int pid, int uid, int amount)
        {
            products.Product oldproduct = database.products.GetProduct(pid);
            if (oldproduct.Uid == -1)
            {
                return false;
            }
            Connection.Close();

            {
                String query = "set identity_insert customer_orders off; INSERT INTO customer_orders (customerid, productid, productbrand, productname, productsize, amount) VALUES (@customerid, @productid, @productbrand, @productname, @productsize, @amount); set identity_insert customer_orders on;";

                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    command.Parameters.AddWithValue("@customerid", uid);
                    command.Parameters.AddWithValue("@productid", pid);
                    command.Parameters.AddWithValue("@productbrand", oldproduct.Merk);
                    command.Parameters.AddWithValue("@productname", oldproduct.Type);
                    command.Parameters.AddWithValue("@productsize", oldproduct.Maat);
                    command.Parameters.AddWithValue("@amount", amount);

                    Connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        
                        Console.WriteLine("Error inserting data into Database!");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

        }
    }

    public class UserDatabase
    {
        public class user
        {
            public int id;
            public string username;
            public string password;
            public user(int id, string username, string password)
            {
                this.id = id;
                this.username = username;
                this.password = password;
            }
            public user()
            {
                this.id = -1;
                this.username = "";
                this.password = "";
            }
        }
        public static user GetUser(String username)
        {
            Connection.Close();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM \"customers\" WHERE nameuser = @username;", Connection))
            {
                cmd.Parameters.AddWithValue("@username", username);

                Connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (!reader.HasRows)
                        return new user();
                    // Read advances to the next row.
                    while (reader.Read())
                    {
                        return new user(reader.GetInt32(reader.GetOrdinal("id")), reader.GetString(reader.GetOrdinal("nameUser")),
                            reader.GetString(reader.GetOrdinal("passUser")));
                    }
                    Connection.Close();
                    return new user();
                }
            }
        }

        public static user newUser(String username, String password)
        {
            Connection.Close();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO customers (nameuser, passuser) VALUES (@username, @password);", Connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);


                Connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (!reader.HasRows)
                        return new user();
                    // Read advances to the next row.
                    while (reader.Read())
                    {
                        Connection.Close();
                        return GetUser(username);
                    }
                    Connection.Close();
                    return new user();
                }
            }
        }
    }
}