using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Concretes.Helpers;
using CarRentingSystem.Commons.Concretes.Logger;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class VehicleRepository : MainRepository<Vehicles>, IDisposable
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

        public override int Update(Vehicles entity)
        {
            try
            {
                Vehicles tempVehicle = Find(entity.Id);
                tempVehicle = entity;
                return base.Update(tempVehicle);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("VehicleRepository::RemoveManagerById::Error occured.", ex);
            }
        }

        public int RemoveVehicleById(int id)
        {
            try
            {
                Vehicles tempVehicle = Find(id);
                return Remove(tempVehicle);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("VehicleRepository::RemoveManagerById::Error occured.", ex);
            }
        }
    }
}
