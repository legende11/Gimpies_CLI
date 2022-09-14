namespace Gimpies_form
{
    partial class ManagerMain
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
            this.Uitloggen = new System.Windows.Forms.Button();
            this.Beheer = new System.Windows.Forms.Button();
            this.Voorraad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uitloggen
            // 
            this.Uitloggen.Location = new System.Drawing.Point(235, 329);
            this.Uitloggen.Name = "Uitloggen";
            this.Uitloggen.Size = new System.Drawing.Size(253, 109);
            this.Uitloggen.TabIndex = 5;
            this.Uitloggen.Text = "Uitloggen";
            this.Uitloggen.UseVisualStyleBackColor = true;
            this.Uitloggen.Click += new System.EventHandler(this.Uitloggen_Click);
            // 
            // Beheer
            // 
            this.Beheer.Location = new System.Drawing.Point(235, 169);
            this.Beheer.Name = "Beheer";
            this.Beheer.Size = new System.Drawing.Size(253, 109);
            this.Beheer.TabIndex = 4;
            this.Beheer.Text = "Schoenen beheer";
            this.Beheer.UseVisualStyleBackColor = true;
            this.Beheer.Click += new System.EventHandler(this.Beheer_Click);
            // 
            // Voorraad
            // 
            this.Voorraad.Location = new System.Drawing.Point(235, 12);
            this.Voorraad.Name = "Voorraad";
            this.Voorraad.Size = new System.Drawing.Size(253, 109);
            this.Voorraad.TabIndex = 3;
            this.Voorraad.Text = "Voorraad";
            this.Voorraad.UseVisualStyleBackColor = true;
            this.Voorraad.Click += new System.EventHandler(this.Voorraad_Click);
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Uitloggen);
            this.Controls.Add(this.Beheer);
            this.Controls.Add(this.Voorraad);
            this.Name = "ManagerMain";
            this.Text = "ManagerMain";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Uitloggen;
        private Button Beheer;
        private Button Voorraad;
    }
}