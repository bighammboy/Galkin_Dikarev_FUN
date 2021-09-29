
namespace WindowsFormsApp1
{
    partial class AddUsertForm
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
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Sername = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.add_user_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Firstname
            // 
            this.Firstname.Location = new System.Drawing.Point(88, 36);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(100, 20);
            this.Firstname.TabIndex = 0;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(88, 62);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(100, 20);
            this.Lastname.TabIndex = 1;
            // 
            // Sername
            // 
            this.Sername.Location = new System.Drawing.Point(88, 88);
            this.Sername.Name = "Sername";
            this.Sername.Size = new System.Drawing.Size(100, 20);
            this.Sername.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(88, 114);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(88, 140);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 4;
            // 
            // add_user_button
            // 
            this.add_user_button.Location = new System.Drawing.Point(100, 190);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(75, 23);
            this.add_user_button.TabIndex = 5;
            this.add_user_button.Text = "Click";
            this.add_user_button.UseVisualStyleBackColor = true;
            this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
            // 
            // AddUsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.add_user_button);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Sername);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Name = "AddUsertForm";
            this.Text = "Add/CHANGE";
            this.Load += new System.EventHandler(this.AddUsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox Sername;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button add_user_button;
    }
}