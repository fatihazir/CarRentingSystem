using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.BusinessLogic.Concretes;
using CarRentingSystem.DataAccess.Entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RentInfoBusiness repo = new RentInfoBusiness();
            repo.UpdateRentInfo(new RentInfos()
            {
                Id = 6,
                IsRented = false,
                IsRequestPending = false,
                StaffThatConfirmsOrRejects = 1
            });
        }
    }
}
