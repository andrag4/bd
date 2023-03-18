using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;

namespace WpfApp1
{
    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WpfApp1.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Cruise> Cruise { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Destination> Destination { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
       
    }
    
}