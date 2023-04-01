using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;

namespace WpfApp1
{
    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {

        }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Cruise> Cruise { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Destination> Destination { get; set; }
        public virtual DbSet<Category> Category { get; set; }
    }
    
}