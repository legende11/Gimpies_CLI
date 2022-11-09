using System.ComponentModel;

namespace Gimpies_form;

partial class manager_toevoegen
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
            this.save_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prijs
            // 
            this.Prijs.Location = new System.Drawing.Point(594, 140);
            this.Prijs.Name = "Prijs";
            this.Prijs.Size = new System.Drawing.Size(100, 23);
            this.Prijs.TabIndex = 17;
            this.Prijs.TextChanged += new System.EventHandler(this.Prijs_TextChanged);
            // 
            // kleur
            // 
            this.kleur.Location = new System.Drawing.Point(594, 111);
            this.kleur.Name = "kleur";
            this.kleur.Size = new System.Drawing.Size(100, 23);
            this.kleur.TabIndex = 15;
            this.kleur.TextChanged += new System.EventHandler(this.kleur_TextChanged);
            // 
            // maat
            // 
            this.maat.Location = new System.Drawing.Point(594, 82);
            this.maat.Name = "maat";
            this.maat.Size = new System.Drawing.Size(100, 23);
            this.maat.TabIndex = 14;
            this.maat.TextChanged += new System.EventHandler(this.maat_TextChanged);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(594, 53);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 23);
            this.type.TabIndex = 13;
            // 
            // merk
            // 
            this.merk.Location = new System.Drawing.Point(594, 24);
            this.merk.Name = "merk";
            this.merk.Size = new System.Drawing.Size(100, 23);
            this.merk.TabIndex = 12;
            this.merk.TextChanged += new System.EventHandler(this.merk_TextChanged);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(12, 12);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(100, 23);
            this.save_but.TabIndex = 10;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // manager_toevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prijs);
            this.Controls.Add(this.kleur);
            this.Controls.Add(this.maat);
            this.Controls.Add(this.type);
            this.Controls.Add(this.merk);
            this.Controls.Add(this.save_but);
            this.Name = "manager_toevoegen";
            this.Text = "manager_toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox Prijs;
    private TextBox kleur;
    private TextBox maat;
    private TextBox type;
    private TextBox merk;
    private Button save_but;
}