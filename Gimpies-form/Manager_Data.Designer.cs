namespace Gimpies_form
{
    partial class Manager_Data
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
            this.txt_left = new System.Windows.Forms.Label();
            this.txt_right = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_left
            // 
            this.txt_left.AutoSize = true;
            this.txt_left.Location = new System.Drawing.Point(12, 9);
            this.txt_left.Name = "txt_left";
            this.txt_left.Size = new System.Drawing.Size(102, 60);
            this.txt_left.TabIndex = 0;
            this.txt_left.Text = "Duurste schoen: \r\nMeeste voorraad: \r\nGemiddelde prijs: \r\nTotale waarde: ";
            // 
            // txt_right
            // 
            this.txt_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_right.AutoSize = true;
            this.txt_right.Location = new System.Drawing.Point(649, 9);
            this.txt_right.Name = "txt_right";
            this.txt_right.Size = new System.Drawing.Size(99, 60);
            this.txt_right.TabIndex = 1;
            this.txt_right.Text = "Totaal verkocht: 1\r\nMeest verkocht:\r\nMinst verkocht:\r\nTotale omzet:\r\n";
            this.txt_right.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Manager_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_right);
            this.Controls.Add(this.txt_left);
            this.Name = "Manager_Data";
            this.Text = "Manager Data";
            this.Load += new System.EventHandler(this.Manager_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt_left;
        private Label txt_right;
    }
}