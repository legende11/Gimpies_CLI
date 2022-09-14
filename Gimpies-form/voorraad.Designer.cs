using System.ComponentModel;

namespace Gimpies_form;

partial class voorraad
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
            this.vorraad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vorraad
            // 
            this.vorraad.AutoSize = true;
            this.vorraad.Location = new System.Drawing.Point(12, 9);
            this.vorraad.Name = "vorraad";
            this.vorraad.Size = new System.Drawing.Size(57, 15);
            this.vorraad.TabIndex = 0;
            this.vorraad.Text = "Voorraad:";
            // 
            // voorraad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vorraad);
            this.Name = "voorraad";
            this.Text = "voorraad";
            this.Load += new System.EventHandler(this.voorraad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label vorraad;
}