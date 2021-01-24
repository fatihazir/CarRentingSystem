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
    public class StaffRepository : MainRepository<Staffs>, IDisposable, Login<Staffs>
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
        public Staffs Login(string username, string password)
        {
            try
            {
                return Find(x => x.Username == username && x.Password == password);
              
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("StaffRepository::Login::Error occured.", ex);
            }
        }
    }
}
