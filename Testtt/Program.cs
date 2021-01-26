using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.BusinessLogic.Concretes;

namespace Testtt
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBusiness business = new VehicleBusiness();
            var t = business.GetAvailableVehicles(new DateTime(2021, 01, 26), new DateTime(2021, 01, 30));
            var list = business.ListVehicles();
            Console.WriteLine("sela");
            Console.ReadKey();
        }
    }
}
