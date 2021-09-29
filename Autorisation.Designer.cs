
namespace Galkin_Dikarev_Fun
{
    partial class Autorisation
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
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.login_b = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Autorisation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(30, 82);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(29, 13);
            this.pass.TabIndex = 12;
            this.pass.Text = "pass";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(30, 56);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(29, 13);
            this.login_label.TabIndex = 11;
            this.login_label.Text = "login";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "add new user";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // login_b
            // 
            this.login_b.Location = new System.Drawing.Point(87, 105);
            this.login_b.Name = "login_b";
            this.login_b.Size = new System.Drawing.Size(75, 23);
            this.login_b.TabIndex = 9;
            this.login_b.Text = "login";
            this.login_b.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(71, 53);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 7;
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 178);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.login_b);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.login);
            this.Name = "Autorisation";
            this.Text = "Autorisation";
            this.Load += new System.EventHandler(this.Autorisation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button login_b;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox login;
    }
}