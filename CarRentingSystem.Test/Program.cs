using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;


namespace CarRentingSystem.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MainRepository<Companies> companyRepo = new MainRepository<Companies>();
            MainRepository<Vehicles> vehicleRepo = new MainRepository<Vehicles>();


            //tum sirketleri listeme
            //var sonuc = companyRepo.ListAll();








            //araba ekleme(sirketi ile beraber)
            //int result = companyRepo.Insert(new Companies()
            //{
            //    Name = "xx",
            //    Address = "xx",
            //    City = "xx",
            //    Point = 1,
            //    PhoneNumber = 454545
            //});

            //Companies comp = companyRepo.Find(x => x.Id == 1);
            //Vehicles vehicle = new Vehicles()
            //{
            //    Brand = "toyota",
            //    ModelName = "yaris",
            //    Companies = comp,
            //};

            //int sonuc = vehicleRepo.Insert(vehicle);






            //sirket üzerinden arabaya ulaşma
            var sonuc = companyRepo.Find(x => x.Id == 1).Vehicles.ToList();
            Console.ReadKey();

        }
    }
}
