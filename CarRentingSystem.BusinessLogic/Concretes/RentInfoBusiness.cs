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
    public class RentInfoBusiness : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public bool Reject(int id)
        {
            try
            {
                bool isSuccess;

                RentInfoRepository repo = new RentInfoRepository();
                int result = repo.Reject(id);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::RentInfoBusiness::Reject::Error occured.", ex);
            }
        }

        public bool Confirm(int id)
        {
            try
            {
                bool isSuccess;

                RentInfoRepository repo = new RentInfoRepository();
                int result = repo.Confirm(id);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::RentInfoBusiness::Confirm::Error occured.", ex);
            }
        }

        public RentInfos Find(int id)
        {
            try
            {
                bool isSuccess;

                RentInfoRepository repo = new RentInfoRepository(); 
                return repo.Find(id);

            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::RentInfoBusiness::Find::Error occured.", ex);
            }
        }
    }
}
