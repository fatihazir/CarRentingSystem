using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Concretes.Helpers;
using CarRentingSystem.Commons.Concretes.Logger;
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
        public List<Vehicles> ListVehicles()
        {
            try
            {
                VehicleRepository repo = new VehicleRepository();
                return repo.ListAll();
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::VehicleBusiness::ListVehicle::Error occured.", ex);
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
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::VehicleBusiness::UpdateVehicle::Error occured.", ex);
            }
        }

        public Vehicles Find(int id)
        {
            try
            {
                VehicleRepository repo = new VehicleRepository();
                return repo.Find(id);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::VehicleBusiness::Find::Error occured.", ex);
            }
        }

        public bool Remove(int id)
        {
            try
            {
                bool isSuccess;

                VehicleRepository repo = new VehicleRepository();
                int result =  repo.RemoveVehicleById(id);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::VehicleBusiness::Remove::Error occured.", ex);
            }
        }

        public List<Vehicles> GetAvailableVehicles(DateTime starting, DateTime ending)
        {
            try
            {
                bool isSuccess;

                VehicleRepository repo = new VehicleRepository();
                return repo.FindAvailableCarBetweenDates(starting, ending);

            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::VehicleBusiness::GetAvailableVehicles::Error occured.", ex);
            }
        }
    }
}
