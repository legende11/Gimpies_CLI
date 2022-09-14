using System.ComponentModel;

namespace Gimpies_form;

partial class manager_menu
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Verwijderen = new System.Windows.Forms.Button();
            this.Aanpassen = new System.Windows.Forms.Button();
            this.Toevoegen = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Verwijderen
            // 
            this.Verwijderen.Location = new System.Drawing.Point(274, 329);
            this.Verwijderen.Name = "Verwijderen";
            this.Verwijderen.Size = new System.Drawing.Size(253, 109);
            this.Verwijderen.TabIndex = 5;
            this.Verwijderen.Text = "Verwijderen";
            this.Verwijderen.UseVisualStyleBackColor = true;
            this.Verwijderen.Click += new System.EventHandler(this.Verwijderen_Click);
            // 
            // Aanpassen
            // 
            this.Aanpassen.Location = new System.Drawing.Point(274, 169);
            this.Aanpassen.Name = "Aanpassen";
            this.Aanpassen.Size = new System.Drawing.Size(253, 109);
            this.Aanpassen.TabIndex = 4;
            this.Aanpassen.Text = "Aanpassen";
            this.Aanpassen.UseVisualStyleBackColor = true;
            this.Aanpassen.Click += new System.EventHandler(this.Aanpassen_Click);
            // 
            // Toevoegen
            // 
            this.Toevoegen.Location = new System.Drawing.Point(274, 12);
            this.Toevoegen.Name = "Toevoegen";
            this.Toevoegen.Size = new System.Drawing.Size(253, 109);
            this.Toevoegen.TabIndex = 3;
            this.Toevoegen.Text = "Toevoegen";
            this.Toevoegen.UseVisualStyleBackColor = true;
            this.Toevoegen.Click += new System.EventHandler(this.Toevoegen_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(12, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 6;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // manager_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.Verwijderen);
            this.Controls.Add(this.Aanpassen);
            this.Controls.Add(this.Toevoegen);
            this.Name = "manager_menu";
            this.Text = "manager_menu";
            this.ResumeLayout(false);

    }

    #endregion

    private Button Verwijderen;
    private Button Aanpassen;
    private Button Toevoegen;
    private Button logout;
}