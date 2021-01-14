using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
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

            //var result = companyBusiness.AddManager(1, new Managers(){Name = "for comp 1"});
            //DefaultDataBusiness defaultDataBusiness = new DefaultDataBusiness();
            //var rep = defaultDataBusiness.InitializeDefaultData();
            //var res = companyBusiness.FindCompany(1);

            ///////SİRKET SİRKET SİRKET SİRKET SİRKET SİRKET SİRKET SİRKET SİRKET SİRKET SİRKET SİRKET ////
            CompanyBusiness companyBusiness = new CompanyBusiness();
            //Insert
            //Companies tempComp = new Companies(){Name = "Temp name2", Address = "Temp adress", City = "Temp city", Point = 4, PhotoURL = "Temp url", DatetimeOfCreated = DateTime.Now};
            //var result = companyBusiness.InsertCompany(tempComp);

            //Remove
            //var result = companyBusiness.RemoveCompany(4);

            //Update
            //Companies temp = companyBusiness.FindCompany(5);
            //temp.Name = "UpdatedName";
            //var result =companyBusiness.UpdateCompany(temp);

            //Adding car
            //Vehicles tempVehicle  = new Vehicles(){Brand = "Test car",CurrentKm = 40000, DatetimeOfCreated = DateTime.Now,Plate = "44ss44"};
            //var result = companyBusiness.AddCar(5, tempVehicle);

            //Removing car
            //Vehicles tempCar = companyBusiness.FindCompany(5).Vehicles.FirstOrDefault();
            //companyBusiness.RemoveCar(5, tempCar);

            //Adding manager
            //Managers tempManager  = new Managers(){Name = "temp maanger", Password = "sadasd"};
            //var result = companyBusiness.AddManager(5, tempManager);

            //Removing manager
            //Managers tempManager = companyBusiness.FindCompany(5).Managers.FirstOrDefault();
            //companyBusiness.RemoveManager(5, tempManager);

            //Adding manager
            //Managers tempManager  = new Managers(){Name = "temp maanger", Password = "sadasd"};
            //var result = companyBusiness.AddManager(5, tempManager);

            //Removing manager
            //Managers tempManager = companyBusiness.FindCompany(5).Managers.FirstOrDefault();
            //companyBusiness.RemoveManager(5, tempManager);

            //Adding staff
            //Staffs tempStaff = new Staffs(){Name = "temp staff"};
            //var result = companyBusiness.AddStaff(5, tempStaff);

            DefaultDataBusiness repo = new DefaultDataBusiness();
            repo.InitializeDefaultData();

        }
    }
}
