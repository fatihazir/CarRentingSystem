using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.Test
{
    public class DataContext : DbContext 
    {
        private static string nameOrConnectionString;

        public DataContext() : base(nameOrConnectionString="CarRenting")
        {
            DataInitializer dataInitializer = new DataInitializer();
        }



        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<RentInfo> Rents { get; set; }

    }
}
