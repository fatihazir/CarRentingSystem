using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Concretes.Helpers;
using CarRentingSystem.Commons.Concretes.Logger;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Abstraction.Additional;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class ManagerRepository : MainRepository<Managers>, IDisposable, Login<Managers>
    {
        private bool _bDisposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
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

        public override int Update(Managers entity)
        {
            try
            {
                Managers tempManager = Find(entity.Id);
                tempManager = entity;
                return base.Update(tempManager);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("ManagerRepository::Update::Error occured.", ex);
            }
        }

        public int RemoveManagerById(int id)
        {
            try
            {
                Managers tempManager = Find(id);
                return Remove(tempManager);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("ManagerRepository::RemoveManagerById::Error occured.", ex);
            }
        }

        public Managers Login(string username, string password)
        {
            try
            {
                return Find(x => x.Username == username && x.Password == password);
                
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("ManagerRepository::Login::Error occured.", ex);
            }
        }
    }
}
