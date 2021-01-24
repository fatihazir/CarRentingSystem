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
    public class ManagerBusiness : IDisposable
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

        public bool InsertManager(Managers entity)
        {
            try
            {
                bool isSuccess;

                ManagerRepository repo = new ManagerRepository();
                int result = repo.Insert(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::ManagerBusiness::InsertManager::Error occured.", ex);
            }
        }
        public bool UpdateManager(Managers entity)
        {
            try
            {
                bool isSuccess;

                ManagerRepository repo = new ManagerRepository();
                int result = repo.Update(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::ManagerBusiness::UpdateManager::Error occured.", ex);
            }
        }

        public Managers Find(int id)
        {
            try
            {
                ManagerRepository repo = new ManagerRepository();
                return repo.Find(id);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::ManagerBusiness::Find::Error occured.", ex);
            }
        }

        public int Remove(int id)
        {
            try
            {
                ManagerRepository repo = new ManagerRepository();
                return repo.RemoveManagerById(id);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::ManagerBusiness::Remove::Error occured.", ex);
            }
        }

        public Managers GetEncryptedKey(string username)
        {
            try
            {
                ManagerRepository repo = new ManagerRepository();
                return repo.GetEncryptedKey(username);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::ManagerBusiness::GetEncKey::Error occured.", ex);
            }
        }

       
    }
}
