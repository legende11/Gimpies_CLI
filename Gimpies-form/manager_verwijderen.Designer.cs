using System.ComponentModel;

namespace Gimpies_form;

partial class manager_verwijderen
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
            this.Prijs = new System.Windows.Forms.TextBox();
            this.kleur = new System.Windows.Forms.TextBox();
            this.maat = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.merk = new System.Windows.Forms.TextBox();
            this.product = new System.Windows.Forms.TextBox();
            this.main_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prijs
            // 
            this.Prijs.Location = new System.Drawing.Point(592, 128);
            this.Prijs.Name = "Prijs";
            this.Prijs.Size = new System.Drawing.Size(100, 23);
            this.Prijs.TabIndex = 16;
            // 
            // kleur
            // 
            this.kleur.Location = new System.Drawing.Point(592, 99);
            this.kleur.Name = "kleur";
            this.kleur.Size = new System.Drawing.Size(100, 23);
            this.kleur.TabIndex = 15;
            // 
            // maat
            // 
            this.maat.Location = new System.Drawing.Point(592, 70);
            this.maat.Name = "maat";
            this.maat.Size = new System.Drawing.Size(100, 23);
            this.maat.TabIndex = 14;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(592, 41);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 23);
            this.type.TabIndex = 13;
            // 
            // merk
            // 
            this.merk.Location = new System.Drawing.Point(592, 12);
            this.merk.Name = "merk";
            this.merk.Size = new System.Drawing.Size(100, 23);
            this.merk.TabIndex = 12;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(12, 12);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 23);
            this.product.TabIndex = 11;
            // 
            // main_but
            // 
            this.main_but.Location = new System.Drawing.Point(12, 53);
            this.main_but.Name = "main_but";
            this.main_but.Size = new System.Drawing.Size(100, 23);
            this.main_but.TabIndex = 10;
            this.main_but.Text = "Load";
            this.main_but.UseVisualStyleBackColor = true;
            this.main_but.Click += new System.EventHandler(this.main_but_Click);
            // 
            // manager_verwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prijs);
            this.Controls.Add(this.kleur);
            this.Controls.Add(this.maat);
            this.Controls.Add(this.type);
            this.Controls.Add(this.merk);
            this.Controls.Add(this.product);
            this.Controls.Add(this.main_but);
            this.Name = "manager_verwijderen";
            this.Text = "manager_verwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox Prijs;
    private TextBox kleur;
    private TextBox maat;
    private TextBox type;
    private TextBox merk;
    private TextBox product;
    private Button main_but;
}