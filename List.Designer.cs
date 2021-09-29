
namespace GbddApps447_GalkinMane
{
    partial class list
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
            this.DELETE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.loginC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD = new System.Windows.Forms.Button();
            this.search_textB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            this.SuspendLayout();
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(12, 41);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(146, 23);
            this.DELETE.TabIndex = 1;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eddit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvusers
            // 
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginC,
            this.Pass,
            this.Firstname_c,
            this.SecondName_c,
            this.LastName_c});
            this.dgvusers.Location = new System.Drawing.Point(196, 12);
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.Size = new System.Drawing.Size(534, 174);
            this.dgvusers.TabIndex = 3;
            this.dgvusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // loginC
            // 
            this.loginC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loginC.HeaderText = "LOGIN";
            this.loginC.Name = "loginC";
            // 
            // Pass
            // 
            this.Pass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pass.HeaderText = "Pass";
            this.Pass.Name = "Pass";
            // 
            // Firstname_c
            // 
            this.Firstname_c.HeaderText = "Firstname";
            this.Firstname_c.Name = "Firstname_c";
            // 
            // SecondName_c
            // 
            this.SecondName_c.HeaderText = "SecondName";
            this.SecondName_c.Name = "SecondName_c";
            // 
            // LastName_c
            // 
            this.LastName_c.HeaderText = "LastName";
            this.LastName_c.Name = "LastName_c";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(12, 12);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(146, 23);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_textB
            // 
            this.search_textB.Location = new System.Drawing.Point(12, 99);
            this.search_textB.Name = "search_textB";
            this.search_textB.Size = new System.Drawing.Size(146, 20);
            this.search_textB.TabIndex = 4;
            this.search_textB.TextChanged += new System.EventHandler(this.search_textB_TextChanged);
            // 
            // list
            // 
            this.AccessibleName = "list";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_textB);
            this.Controls.Add(this.dgvusers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.ADD);
            this.Name = "list";
            this.Text = "list";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvusers;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName_c;
        private System.Windows.Forms.TextBox search_textB;
    }
}

