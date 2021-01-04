using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.DBCreator
{
    public class DataContext : DbContext
    {

        public DataContext() : base("CarRenting")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<RentInfo> RentInfos { get; set; }
        public DbSet<Staff> Staves { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
            
    }
}
