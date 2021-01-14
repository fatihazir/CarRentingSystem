using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Concretes;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.BusinessLogic.Concretes
{
    public class VehicleBusiness : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public List<Vehicles> List()
        {
            try
            {
                VehicleRepository repo = new VehicleRepository();
                return repo.ListAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool InsertVehicle(Vehicles entity)
        {
            try
            {
                bool isSuccess;

                VehicleRepository repo = new VehicleRepository();
                int result = repo.Insert(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateVehicle(Vehicles entity)
        {
            try
            {
                bool isSuccess;

                VehicleRepository repo = new VehicleRepository();
                int result = repo.Update(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Vehicles Find(int id)
        {
            try
            {
                VehicleRepository repo = new VehicleRepository();
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
                VehicleRepository repo = new VehicleRepository();
                return repo.RemoveVehicleById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
