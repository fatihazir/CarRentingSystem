using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class ManagerRepository : MainRepository<Managers>
    {
        public void ManagerTest()
        {
            var x = 10;
        }
    }
}
