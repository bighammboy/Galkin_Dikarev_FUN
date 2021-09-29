using Gbdd_447_Galkin.Classes;
using GbddApps447_GalkinMane;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes.Entyties;

namespace Galkin_Dikarev_Fun
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            User user = EFModel.init().Users.Where(x => x.Login == login.Text && x.Pass == pass.Text).FirstOrDefault();
            if (user == null)
            {

                MessageBox.Show("no BRAH");
            }
            else
            {
                MessageBox.Show("yeah BRAH"+user.FirstName);
                Hide();
                new list().ShowDialog();
                Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
