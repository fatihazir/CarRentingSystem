using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.DBCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataContext db = new DataContext();
                Company comp = new Company() { City = "Izmir", Name = "KeyboardComp", PhoneNumber = 45454545 };
                db.Companies.Add(comp);
                db.SaveChanges();

                Console.WriteLine("Database created succesfully.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during database initalize. >> " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
