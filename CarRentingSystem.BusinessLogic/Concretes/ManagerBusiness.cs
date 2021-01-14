using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateManeger(Managers entity)
        {
            try
            {
                bool isSuccess;

                ManagerRepository repo = new ManagerRepository();
                int result = repo.Update(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Managers Find(int id)
        {
            try
            {
                ManagerRepository repo = new ManagerRepository();
                return repo.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Remove(int id)
        {
            try
            {
                ManagerRepository repo = new ManagerRepository();
                return repo.RemoveManagerById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
