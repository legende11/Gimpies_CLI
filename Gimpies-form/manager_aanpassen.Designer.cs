using System.ComponentModel;

namespace Gimpies_form;

partial class manager_aanpassen
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
            this.load_but = new System.Windows.Forms.Button();
            this.save_but = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.TextBox();
            this.merk = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.kleur = new System.Windows.Forms.TextBox();
            this.maat = new System.Windows.Forms.TextBox();
            this.Prijs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // load_but
            // 
            this.load_but.Location = new System.Drawing.Point(22, 78);
            this.load_but.Name = "load_but";
            this.load_but.Size = new System.Drawing.Size(46, 23);
            this.load_but.TabIndex = 0;
            this.load_but.Text = "Load";
            this.load_but.UseVisualStyleBackColor = true;
            this.load_but.Click += new System.EventHandler(this.load_but_Click);
            // 
            // save_but
            // 
            this.save_but.Location = new System.Drawing.Point(74, 78);
            this.save_but.Name = "save_but";
            this.save_but.Size = new System.Drawing.Size(48, 23);
            this.save_but.TabIndex = 1;
            this.save_but.Text = "Save";
            this.save_but.UseVisualStyleBackColor = true;
            this.save_but.Click += new System.EventHandler(this.save_but_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(22, 37);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 23);
            this.product.TabIndex = 2;
            // 
            // merk
            // 
            this.merk.Location = new System.Drawing.Point(602, 37);
            this.merk.Name = "merk";
            this.merk.Size = new System.Drawing.Size(100, 23);
            this.merk.TabIndex = 3;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(602, 66);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 23);
            this.type.TabIndex = 4;
            // 
            // kleur
            // 
            this.kleur.Location = new System.Drawing.Point(602, 124);
            this.kleur.Name = "kleur";
            this.kleur.Size = new System.Drawing.Size(100, 23);
            this.kleur.TabIndex = 6;
            // 
            // maat
            // 
            this.maat.Location = new System.Drawing.Point(602, 95);
            this.maat.Name = "maat";
            this.maat.Size = new System.Drawing.Size(100, 23);
            this.maat.TabIndex = 5;
            // 
            // Prijs
            // 
            this.Prijs.Location = new System.Drawing.Point(602, 153);
            this.Prijs.Name = "Prijs";
            this.Prijs.Size = new System.Drawing.Size(100, 23);
            this.Prijs.TabIndex = 8;
            // 
            // manager_aanpassen
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
            this.Controls.Add(this.save_but);
            this.Controls.Add(this.load_but);
            this.Name = "manager_aanpassen";
            this.Text = "manager_aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button load_but;
    private Button save_but;
    private TextBox product;
    private TextBox merk;
    private TextBox type;
    private TextBox kleur;
    private TextBox maat;
    private TextBox Prijs;
}