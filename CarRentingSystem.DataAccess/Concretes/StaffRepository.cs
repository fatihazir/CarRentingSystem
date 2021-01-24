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
        public Staffs GetEncryptedKey(string username)
        {
            try
            {
                Staffs result = Find(x => x.Username == username);
                Staffs tempStaff = new Staffs()
                {
                    Id = result.Id,
                    Password = result.Password
                };

                return tempStaff;

            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("StaffRepository::GetEncKey::Error occured.", ex);
            }
        }
       
    }
}
