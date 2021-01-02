using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.Test
{
    class Program 
    {
        static void Main(string[] args) 
        {
            
            DataContext db = new DataContext();
            db.Customers.Add(new Customer());
            Console.WriteLine("Sunucumuz açıldı");
            Console.ReadKey();
 

        }
    }
}
