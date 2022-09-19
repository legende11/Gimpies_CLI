namespace Gimpies_form;

public class usercl
{
    public int id;
    public string username;
    public string password;
    public int rank;
    public usercl(int Id, string Username, string Password, int Rank)
    {
        id = Id;
        username = Username;
        password = Password;
        rank = Rank;
    }
}