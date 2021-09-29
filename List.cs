using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using WindowsFormsApp1.Classes.Entyties;
using Gbdd_447_Galkin.Classes;
using WindowsFormsApp1;
using System.Linq;

namespace GbddApps447_GalkinMane
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "192.168.201.12",
                Port = 3306,
                UserID = "ISP347_GalkinGD",
                Password = "azaza312",
                Database = "ISP347_GalkinGD_Dikarev",
                CharacterSet = "utf8"
            };

        
        }
        private void UpdateData()
        {
            dgvusers.Rows.Clear();
            {
                foreach (User user in EFModel.init().Users.Where(x => x.FirstName.Contains(search_textB.Text)||
                        x.SecondName.Contains(search_textB.Text)||x.SerName.Contains(search_textB.Text)||
                        x.Login.Contains(search_textB.Text)||x.Pass.Contains(search_textB.Text)))
                
                {
                    int x = dgvusers.Rows.Add(user.FirstName, user.SecondName, user.Sername, user.Login, user.Pass);
                    dgvusers.Rows[x].Tag = user;
                }
            }
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvusers.SelectedRows.Count>0)
                {
                AddUsertForm adduser = new AddUsertForm(dgvusers.SelectedRows[0].Tag as User);
                adduser.ShowDialog();
                UpdateData();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvusers.SelectedRows.Count > 0)
            {
                EFModel.init().Users.Remove(dgvusers.SelectedRows[0].Tag as User);
                EFModel.init().SaveChanges();
                UpdateData();

            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void search_textB_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
    }


