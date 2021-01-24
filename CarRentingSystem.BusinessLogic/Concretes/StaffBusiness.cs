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
        public Staffs GetEncryptedKey(string username)
        {
            try
            {
                StaffRepository repo = new StaffRepository();
                return repo.GetEncryptedKey(username);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::StaffBusiness::GetEncKey::Error occured.", ex);
            }
        }

        public Staffs Find(int id)
        {
            try
            {
                StaffRepository repo = new StaffRepository();
                return repo.Find(id);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::StaffBusiness::Find::Error occured.", ex);
            }
        }

    }
}
