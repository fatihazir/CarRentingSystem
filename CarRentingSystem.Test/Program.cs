using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;
using CarRentingSystem.Models.Concretes;


namespace CarRentingSystem.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMain<Companies> repo = new DbMain<Companies>();;
            var sonuc = repo.ListAll();
            Console.ReadKey();

        }
    }
}
