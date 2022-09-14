using System.Windows.Forms;

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
        Form toevoegen = new voorraad();
        toevoegen.ShowDialog();
        this.Show();
    }

    private void Aanpassen_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form aanpassen = new voorraad();
        aanpassen.ShowDialog();
        this.Show();
    }

    private void Verwijderen_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form verwijderen = new voorraad();
        verwijderen.ShowDialog();
        this.Show();
    }

    private void logout_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}