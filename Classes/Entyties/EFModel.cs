
using GbddApps447_GalkinMane;
using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;
using WindowsFormsApp1.Classes.Entyties;

namespace Gbdd_447_Galkin.Classes
{ 
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EFModel : DbContext
    {
        private static EFModel Instance;
        public static EFModel init()
        {
            if (Instance == null)
            {
                Instance = new EFModel();
            }
            return Instance;
        }
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WindowsFormsApp1.Classes.Entyties.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public EFModel()
             : base("Server = 192.168.201.12; Port = 3306; UserID = ISP347_GalkinGD; Password = azaza312; Database = ISP347_GalkinGD_Dikarev;CharacterSet = utf8")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<User> Users { set; get; }
        public virtual DbSet<Sell> Sells  { set; get; }
        public virtual DbSet<Tovar> Tovars { set; get; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}