using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Concretes;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.BusinessLogic.Concretes
{
    public class CustomerBusiness : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public bool InsertCustomer(Customers entity)
        {
            try
            {
                bool isSuccess;

                 CustomerRepository repo = new CustomerRepository();
                int result = repo.Insert(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Customers FindCustomerByIdentificatonNumber(int identificationNumber)
        {
            try
            {
                CustomerRepository repo = new CustomerRepository();
                return repo.Find(x => x.IdentificationNumber == identificationNumber);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

    }
}
