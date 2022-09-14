using System.ComponentModel;

namespace Gimpies_form;

partial class verkoop
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
            this.product_inp = new System.Windows.Forms.TextBox();
            this.verkoop_but = new System.Windows.Forms.Button();
            this.aantal_inp = new System.Windows.Forms.TextBox();
            this.Aantal = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.Label();
            this.ERROR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // product_inp
            // 
            this.product_inp.Location = new System.Drawing.Point(131, 12);
            this.product_inp.Name = "product_inp";
            this.product_inp.Size = new System.Drawing.Size(162, 23);
            this.product_inp.TabIndex = 0;
            // 
            // verkoop_but
            // 
            this.verkoop_but.Location = new System.Drawing.Point(131, 120);
            this.verkoop_but.Name = "verkoop_but";
            this.verkoop_but.Size = new System.Drawing.Size(162, 23);
            this.verkoop_but.TabIndex = 1;
            this.verkoop_but.Text = "Verkoop";
            this.verkoop_but.UseVisualStyleBackColor = true;
            this.verkoop_but.Click += new System.EventHandler(this.verkoop_but_Click);
            // 
            // aantal_inp
            // 
            this.aantal_inp.Location = new System.Drawing.Point(131, 65);
            this.aantal_inp.Name = "aantal_inp";
            this.aantal_inp.Size = new System.Drawing.Size(162, 23);
            this.aantal_inp.TabIndex = 2;
            // 
            // Aantal
            // 
            this.Aantal.AutoSize = true;
            this.Aantal.Location = new System.Drawing.Point(20, 73);
            this.Aantal.Name = "Aantal";
            this.Aantal.Size = new System.Drawing.Size(41, 15);
            this.Aantal.TabIndex = 3;
            this.Aantal.Text = "Aantal";
            // 
            // product
            // 
            this.product.AutoSize = true;
            this.product.Location = new System.Drawing.Point(20, 15);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(49, 15);
            this.product.TabIndex = 4;
            this.product.Text = "product";
            // 
            // ERROR
            // 
            this.ERROR.AutoSize = true;
            this.ERROR.Location = new System.Drawing.Point(331, 15);
            this.ERROR.Name = "ERROR";
            this.ERROR.Size = new System.Drawing.Size(35, 15);
            this.ERROR.TabIndex = 5;
            this.ERROR.Text = "Error:";
            // 
            // verkoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ERROR);
            this.Controls.Add(this.product);
            this.Controls.Add(this.Aantal);
            this.Controls.Add(this.aantal_inp);
            this.Controls.Add(this.verkoop_but);
            this.Controls.Add(this.product_inp);
            this.Name = "verkoop";
            this.Text = "verkoop";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox product_inp;
    private Button verkoop_but;
    private TextBox aantal_inp;
    private Label Aantal;
    private Label product;
    private Label ERROR;
}