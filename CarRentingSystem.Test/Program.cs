using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Concretes;

namespace CarRentingSystem.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Calisti..");
            Console.ReadKey();
            CompanyRepository repo = new CompanyRepository();
        }
    }
}
