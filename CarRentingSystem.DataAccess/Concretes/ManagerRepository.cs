using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class ManagerRepository : MainRepository<Managers>, IDisposable
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
            catch (Exception)
            {

                throw;
            }
        }

        public int RemoveManagerById(int id)
        {
            try
            {
                Managers tempManager = Find(id);
                return Remove(tempManager);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
