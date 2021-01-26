using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Concretes.Helpers;
using CarRentingSystem.Commons.Concretes.Logger;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class RentInfoRepository : MainRepository<RentInfos>, IDisposable
    {
        private bool _bDisposed;

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        protected virtual void Dispose(bool bDisposing)
        {
            // Check the Dispose method called before.
            if (!_bDisposed)
            {
                if (bDisposing)
                {
                    // Clean the resources used.
                    db = null;
                }

                _bDisposed = true;
            }
        }

        public int Reject(int id)
        {
            try
            {
                RentInfos tempRentInfo = Find(id);
                tempRentInfo.IsRented = false;
                tempRentInfo.IsRequestPending = false;
                return base.Update(tempRentInfo);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("RentInfoRepository::Reject::Error occured.", ex);
            }
        }

        public int Confirm(int id)
        {
            try
            {
                RentInfos tempRentInfo = Find(id);
                tempRentInfo.IsRented = true;
                tempRentInfo.IsRequestPending = false;
                return base.Update(tempRentInfo);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("RentInfoRepository::Confirm::Error occured.", ex);
            }


        }

        public RentInfos GetRezInfoByCustomerIdentificatonNumber(int id)
        {
            try
            {
               return Find(x => x.Customers.IdentificationNumber == id);
                
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("RentInfoRepository::GetRezInfo::Error occured.", ex);
            }
        }
    }
}
