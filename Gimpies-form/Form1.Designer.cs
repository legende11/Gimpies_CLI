namespace Gimpies_form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_b = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Tries = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(12, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(30, 15);
            this.username.TabIndex = 0;
            this.username.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // username_b
            // 
            this.username_b.Location = new System.Drawing.Point(161, 6);
            this.username_b.Name = "username_b";
            this.username_b.Size = new System.Drawing.Size(100, 23);
            this.username_b.TabIndex = 2;
            this.username_b.TextChanged += new System.EventHandler(this.username_b_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(161, 42);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Tries
            // 
            this.Tries.AutoSize = true;
            this.Tries.Location = new System.Drawing.Point(669, 6);
            this.Tries.Name = "Tries";
            this.Tries.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tries.Size = new System.Drawing.Size(119, 15);
            this.Tries.TabIndex = 4;
            this.Tries.Text = "Pogingen resterent: 3";
            this.Tries.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 113);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(249, 23);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Tries);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username;
        private Label label2;
        private TextBox username_b;
        private TextBox password;
        private Label Tries;
        private Button Login;
    }
}