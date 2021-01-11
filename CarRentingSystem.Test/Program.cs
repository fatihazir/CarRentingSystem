using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.BusinessLogic.Concretes;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;


namespace CarRentingSystem.Test
{
    class Program
    {
        static void Main(string[] args)
        {

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
            CompanyBusiness companyBusiness = new CompanyBusiness();
            //var comps = companyBusiness.ListCompanies(i => i.Id == 2);
            //var comps = companyBusiness.FindCompany(i => i.Id == 2);
            //var comp = companyBusiness.InsertCompany(new Companies(){Name = "blablab", Address = "Antakya", PhoneNumber = 555});
            //var comp = companyBusiness.UpdateCompany(new Companies() { Name = "blablab", Address = "AntakyaUpdated", PhoneNumber = 555, Id = 6});
            //var comp = companyBusiness.RemoveCompany(5);
            //Companies comp = companyBusiness.FindCompany(2);
            //comp.Name = "updated";
            //var result = companyBusiness.UpdateCompany(comp);

           
            Vehicles tempVehicle = new Vehicles(){Brand = "Test2"};
            companyBusiness.AddCarToCompany(1, tempVehicle);
            var comp =companyBusiness.FindCompany(1);
            Console.ReadKey();

        }
    }
}
