using System.Data.SqlClient;
using Gimpies;

namespace Gimpies_form;

public class database
{
    private static readonly string constring =
        "Data Source=DESKTOP-TJJ8LR1\\SQLEXPRESS;Initial Catalog=gimpies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    private static SqlConnection Connection = new SqlConnection(constring);


    public static List<Product> getproducts()
    {
        List<Product> products = new List<Product>();


        using SqlCommand cmd = new SqlCommand("SELECT * FROM \"product\";", Connection);
        Connection.Close();
        Connection.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
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

        return products;
    }


    public static int getaantal(int uid)
    {
        using SqlCommand cmd = new SqlCommand("SELECT * FROM \"product\" WHERE id=@id;", Connection);
        cmd.Parameters.AddWithValue("@id", uid);
        Connection.Close();
        Connection.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        // Check is the reader has any rows at all before starting to read.
        if (!reader.HasRows)
            return -1;
        // Read advances to the next row.
        while (reader.Read())
        {
            if (reader.GetInt32(reader.GetOrdinal("id")) == uid)
            {
                return reader.GetInt32(reader.GetOrdinal("aantal_verkoct"));
            }
        }
        Connection.Close();

        return -1;
    }

    public void SaveProducts(Product product)
    {
        Connection.Close();

        {
            using SqlCommand command =
                new SqlCommand(
                    "set identity_insert product off; INSERT INTO product (brand, type, size, color, price, aantal) VALUES (@brand, @type, @size, @color, @price, @aantal); set identity_insert product on;",
                    Connection);
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

        Product.products = database.getproducts();
    }


    public void DeleteProdut(int id)
    {
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
            String query = "DELETE FROM product WHERE id = @id; ";

            using SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@id", id);


            Connection.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error inserting data into Database!");
        }
        // DELETE FROM table_name WHERE condition; 
    }

    public static void updateProduct(int id, Product product, int? verkocht)
    {
        int verkocht2;
        if (verkocht == null)
        {
            verkocht2 = getaantal(id);
        }
        else
        {
            verkocht2 = getaantal(id) + (int)verkocht;
        }
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
            String query = "UPDATE product SET brand = @brand, type = @type, color = @color, price = @price, aantal = @aantal, aantal_verkoct = @verkocht WHERE id = @id;";

            using SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@brand", product.Merk);
            command.Parameters.AddWithValue("@type", product.Type);
            command.Parameters.AddWithValue("@size", product.Maat);
            command.Parameters.AddWithValue("@color", product.Kleur);
            command.Parameters.AddWithValue("@price", product.Prijs);
            command.Parameters.AddWithValue("@aantal", product.Aantal);
            command.Parameters.AddWithValue("@verkocht", verkocht2);


            Connection.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error inserting data into Database!");
        }
    }

    public int getrank(string username)
    {
        using SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\";", Connection);
        Connection.Close();
        Connection.Open();

        using SqlDataReader reader = cmd.ExecuteReader();
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

    public bool CheckLogin(string username, string password)
    {
        using SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\";", Connection);
        Dictionary<string, string> Logins = new Dictionary<string, string>();
        Logins.Clear();
        Connection.Close();
        Connection.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
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
        catch (Exception)
        {
            return false;
        }
    }

    public void NewUser(string username, string password, int rank)
    {
        Connection.Close();

        {
            String query =
                "set identity_insert product off; INSERT INTO login (nameUser, passUser, TypeUser) VALUES (@username, @password, @id); set identity_insert product on;";

            using SqlCommand command = new SqlCommand(query, Connection);
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


    public static usercl GetUser(int id)
    {
        using SqlCommand cmd = new SqlCommand("SELECT * FROM \"login\" WHERE id = @id;", Connection);
        cmd.Parameters.AddWithValue("@id", id);
        Connection.Close();
        Connection.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
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
        }
        Connection.Close();
        return new usercl(-1, "Error", "Error", -1);

    }

    public void deleteUser(int id)
    {
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
            String query = "DELETE FROM login WHERE id = @id; ";

            using SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@id", id);


            Connection.Open();
            int result = command.ExecuteNonQuery();

            // Check Error
            if (result < 0)
                Console.WriteLine("Error inserting data into Database!");
        }
        // DELETE FROM table_name WHERE condition; 
    }

    public static void updateUser(int id, string username, string password, int typeuser)
    {
        Connection.Close();

        {
            // String query = "UPDATE product SET (id,brand, type, size, color, price, aantal) VALUES (@id, @brand, @type, @size, @color, @price, @aantal) WHERE id = @id";
            String query = "UPDATE login SET nameUser = @nameUser, passUser = @passUser, TypeUser = @typeuser WHERE id = @id;";

            using SqlCommand command = new SqlCommand(query, Connection);
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