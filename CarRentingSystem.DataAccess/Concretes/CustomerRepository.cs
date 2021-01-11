using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class CustomerRepository : MainRepository<Customers>
    {
        public void CustomerTest()
        {
            var x = 10;
        }
    }
}
