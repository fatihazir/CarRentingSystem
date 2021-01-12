using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.BusinessLogic.Concretes
{
    public class DefaultDataBusiness: IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public bool InitializeDefaultData()
        {
            List<Companies> companies = new List<Companies>()
            {
                new Companies()
                {
                    Name = "Light Car",Address = "Taksim 55",City = "Istanbul", PhoneNumber = 02128542298
                    ,Point = 0
                },
                new Companies()
                {
                    Name = "Foreign Car",Address = "Center bla bla",City = "Riga", PhoneNumber = 3124158846
                    ,Point = 1
                }
            };

            CompanyBusiness companyBusiness = new CompanyBusiness();

            foreach (var company in companies)
            {
                companyBusiness.InsertCompany(company);
            }

            //List<Manager> managers = new List<Manager>()
            //{
            //    new Manager()
            //    {
            //        Name = "Fatih", Surname = "Hazir, Username = "Fatih123", Password = "fatih123",
            //        Address = "Izmir Karsiyaka", Salary = 9000
            //    },
            //    new Manager()
            //    {
            //        Name = "Insan", Surname = "Oglu", Username = "Insan123", Password = "insan123",
            //        Address = "Izmir Bayrakli", Salary = 11000
            //    },
            //};

            //foreach (var manager in managers)
            //{
            //    context.Managers.Add(manager);
            //}

            //List<Vehicle> vehicles = new List<Vehicle>()
            //{
            //    new Vehicle()
            //    {
            //        Brand = "Opel", ModelName = "Astra",AmountOfSeat = 4, CurrentKm = 10000, DailyRentPrice = 10,HaveAirbag = true,
            //        VolumeOfLuggage = 250,DailyKmMax = 500,MinimumAgeLimit = 18,ModelYear = 2016,RequiredOldForLicence = 4,
            //        Plate ="48 GB 019"
            //    },
            //    new Vehicle()
            //    {
            //        Brand = "Toyota", ModelName = "Yaris",AmountOfSeat = 4, CurrentKm = 20000, DailyRentPrice = 20,HaveAirbag = true,
            //        VolumeOfLuggage = 200,DailyKmMax = 50,MinimumAgeLimit = 18,ModelYear = 2007,RequiredOldForLicence = 0,
            //        Plate ="48 GB 020"
            //    },
            //    new Vehicle()
            //    {
            //        Brand = "Bmw", ModelName = "520D",AmountOfSeat = 4, CurrentKm = 800000, DailyRentPrice = 100,HaveAirbag = true,
            //        VolumeOfLuggage = 450,DailyKmMax = 500,MinimumAgeLimit = 18,ModelYear = 2016,RequiredOldForLicence = 8,
            //        Plate ="48 GB 050"
            //    },
            //};

            //foreach (var vehicle in vehicles)
            //{
            //    context.Vehicles.Add(vehicle);
            //}

            return true;
        }
    }
}
