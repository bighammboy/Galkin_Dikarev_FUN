using System;
using GbddApps447_GalkinMane;
using System.Windows.Forms;
using Gbdd_447_Galkin.Classes;

namespace WindowsFormsApp1
{
    public partial class AddUsertForm : Form
    {

        User EditUser;

        public AddUsertForm(User user)
        {
            EditUser = user;
            InitializeComponent();
            Firstname.Text = user.FirstName;
            Sername.Text = user.SerName;
            Lastname.Text = user.SecondName;
            Login.Text = user.Login;
            Pass.Text = user.Pass;
            
        }

        private void add_user_button_Click(object sender, EventArgs e)
        {
            EditUser.FirstName = Firstname.Text;
            EditUser.Sername = Sername.Text;
            EditUser.SecondName = Lastname.Text;
            EditUser.Login = Login.Text;
            EditUser.Pass = Pass.Text;

            if (EditUser.id == 0)
            {
                EFModel.init().Users.Add(EditUser);
            }
            EFModel.init().SaveChanges();
        }

        private void AddUsertForm_Load(object sender, EventArgs e)
        {

        }
    }
}
