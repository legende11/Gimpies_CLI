namespace Gimpies_form;

public partial class manager_menu : Form
{
    public manager_menu()
    {
        InitializeComponent();
    }

    private void Toevoegen_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form toevoegen = new manager_toevoegen();
        toevoegen.ShowDialog();
        this.Show();
    }

    private void Aanpassen_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form aanpassen = new manager_aanpassen();
        aanpassen.ShowDialog();
        this.Show();
    }

    private void Verwijderen_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form verwijderen = new manager_verwijderen();
        verwijderen.ShowDialog();
        this.Show();
    }

    private void logout_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Users_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form users = new users();
        users.ShowDialog();
        this.Show();
    }

    private void But_Overzicht_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form overzicht = new Manager_Data();
        overzicht.ShowDialog();
        this.Show();
    }
}