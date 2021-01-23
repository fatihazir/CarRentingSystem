using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Concretes.Helpers;
using CarRentingSystem.Commons.Concretes.Logger;
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
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CustomerBusiness::InsertCustomer::Error occured.", ex);
            }
        }

        public Customers FindCustomerByIdentificatonNumber(int identificationNumber)
        {
            try
            {
                CustomerRepository repo = new CustomerRepository();
                return repo.Find(x => x.IdentificationNumber == identificationNumber);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CustomerBusiness::FindCustomerByIdentificationNumber::Error occured.", ex);
            }
        }

       

    }
}
