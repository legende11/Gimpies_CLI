namespace Gimpies_form
{
    partial class users
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
            this.inpID = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.NEW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inpID
            // 
            this.inpID.Location = new System.Drawing.Point(30, 22);
            this.inpID.Name = "inpID";
            this.inpID.Size = new System.Drawing.Size(100, 23);
            this.inpID.TabIndex = 0;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(615, 33);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 23);
            this.id.TabIndex = 1;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(615, 62);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(615, 91);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 3;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(30, 76);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(100, 23);
            this.load.TabIndex = 4;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(149, 76);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 5;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(30, 125);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 6;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // NEW
            // 
            this.NEW.Location = new System.Drawing.Point(149, 125);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(75, 23);
            this.NEW.TabIndex = 7;
            this.NEW.Text = "new";
            this.NEW.UseVisualStyleBackColor = true;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NEW);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.load);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.id);
            this.Controls.Add(this.inpID);
            this.Name = "users";
            this.Text = "users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inpID;
        private TextBox id;
        private TextBox username;
        private TextBox password;
        private Button load;
        private Button update;
        private Button delete;
        private Button NEW;
    }
}