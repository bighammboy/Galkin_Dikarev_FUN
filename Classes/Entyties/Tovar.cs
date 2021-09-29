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
        public class Tovar
    {
        public int TovarID { set; get; }
        [Required]
        public string TovarName { set; get; }
        [Required]
        public decimal TovarPrice { set; get; }
        public virtual List<Sell> Sells { set; get; }
        public Tovar()
        {
            Sells = new List<Sell>();
        }
    }
    
}
