using System;
using MySql.Data.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;

namespace GbddApps447_GalkinMane
{
    public class User
    {
        internal string SerName;

        [Key]
        public int id { get; set; }
        [Required,MaxLength(64)]
        public string FirstName { get; set; }
        [Required, MaxLength(32)]
        public string SecondName { get; set; }
        public string Sername { get; set; }
        [Required,MaxLength(32), Index(IsUnique =true)]
        public string Login { get; set; }
        [Required, MaxLength(32)]
        public string Pass { get; set; }

        public static implicit operator User(UserControl v)
        {
            throw new NotImplementedException();
        }
    }
}
