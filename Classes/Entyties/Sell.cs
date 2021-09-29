using Gbdd_447_Galkin.Classes;
using GbddApps447_GalkinMane;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes.Entyties
{
        public class Sell
    {
        [Key]
        public int SellID { set; get; }
        [Required]
        public DateTime SellDateID { set; get; }
        [Required]

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User user { set; get; }
    }
}
