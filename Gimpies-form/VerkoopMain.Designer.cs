namespace Gimpies_form
{
    partial class VerkoopMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Voorraad = new System.Windows.Forms.Button();
            this.Verkopen = new System.Windows.Forms.Button();
            this.Uitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Voorraad
            // 
            this.Voorraad.Location = new System.Drawing.Point(259, 12);
            this.Voorraad.Name = "Voorraad";
            this.Voorraad.Size = new System.Drawing.Size(253, 109);
            this.Voorraad.TabIndex = 0;
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.UseVisualStyleBackColor = true;
            this.Voorraad.Click += new System.EventHandler(this.Voorraad_Click);
            // 
            // Verkopen
            // 
            this.Verkopen.Location = new System.Drawing.Point(259, 169);
            this.Verkopen.Name = "Verkopen";
            this.Verkopen.Size = new System.Drawing.Size(253, 109);
            this.Verkopen.TabIndex = 1;
            this.Verkopen.Text = "\n        \n      Schoenen verkopen";
            this.Verkopen.UseVisualStyleBackColor = true;
            this.Verkopen.Click += new System.EventHandler(this.Verkopen_Click);
            // 
            // Uitloggen
            // 
            this.Uitloggen.Location = new System.Drawing.Point(259, 329);
            this.Uitloggen.Name = "Uitloggen";
            this.Uitloggen.Size = new System.Drawing.Size(253, 109);
            this.Uitloggen.TabIndex = 2;
            this.Uitloggen.Text = "Uitloggen";
            this.Uitloggen.UseVisualStyleBackColor = true;
            this.Uitloggen.Click += new System.EventHandler(this.Uitloggen_Click);
            // 
            // VerkoopMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Uitloggen);
            this.Controls.Add(this.Verkopen);
            this.Controls.Add(this.Voorraad);
            this.Name = "VerkoopMain";
            this.Text = "Verkoop";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Voorraad;
        private Button Verkopen;
        private Button Uitloggen;
    }
}