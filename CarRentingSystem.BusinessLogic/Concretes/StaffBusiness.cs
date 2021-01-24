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
    public class StaffBusiness : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public List<Managers> ListManagers()
        {
            try
            {
                ManagerRepository repo = new ManagerRepository();
                return repo.ListAll();
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::ManagerBusiness::ListManagers::Error occured.", ex);
            }
        }

        public Staffs Login(string username, string password)
        {
            try
            {
                StaffRepository repo = new StaffRepository();
                return repo.Login(username, password);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::StaffBusiness::Login::Error occured.", ex);
            }
        }
    }
}
