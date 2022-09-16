using System.Data.SqlClient;

namespace Gimpies_form;

public class database
{
    private static readonly string constring =
        "Data Source=DESKTOP-TJJ8LR1\\SQLEXPRESS;Initial Catalog=gimpies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    public SqlConnection Connection = new SqlConnection(constring);


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
}