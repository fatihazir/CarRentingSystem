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
    public class CompanyRepository : MainRepository<Companies>, ICompanyAdditionalRepository, IDisposable
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

        public override int Update(Companies entity)
        {
            try
            {
                Companies tempComp = Find(entity.Id);
                tempComp = entity;
                return base.Update(tempComp);
            }
            catch (Exception ex )
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::Update::Error occured.", ex);
            }
        }

        public int RemoveCompanyById(int id)
        {
            try
            {
                Companies tempComp = Find(id);
                return Remove(tempComp);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::RemoveCompanyById::Error occured.", ex);
            }
        }

        public int AddCarToCompany(int companyId,Vehicles entity)
        {
            try
            {
                Companies tempComp = Find(companyId);

                tempComp.Vehicles.Add(entity);
                return Update(tempComp);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::AddCarToCompany::Error occured.", ex);
            }
        }

        public int RemoveCarFromCompany(int companyId, int vehicleId)
        {
            try
            {
                Companies tempComp = Find(companyId);

                VehicleRepository tempVehicleRepository = new VehicleRepository();
                Vehicles tempCar = tempVehicleRepository.Find(vehicleId);

                tempComp.Vehicles.Remove(tempCar);
                return Update(tempComp);
            }
            catch (Exception ex )
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::RemoveCarFromCompany::Error occured.", ex);
            }
        }

        public List<Vehicles> ListCars(int companyId)
        {
            try
            {
                Companies tempComp = Find(companyId);
                return tempComp.Vehicles.ToList();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::ListCars::Error occured.", ex);
            }
        }

        public int AddManagerToCompany(int companyId, int managerId)
        {
            try
            {
                Companies tempComp = Find(companyId);

                ManagerRepository tempManagerRepository = new ManagerRepository();
                Managers tempManager = tempManagerRepository.Find(managerId);

                tempComp.Managers.Add(tempManager);
                return Update(tempComp);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::AddManagerToCompany::Error occured.", ex);
            }
        }

        public int RemoveManagerFromCompany(int companyId, int managerId)
        {
            try
            {
                Companies tempComp = Find(companyId);

                ManagerRepository tempManagerRepository = new ManagerRepository();
                Managers tempManager = tempManagerRepository.Find(managerId);

                tempComp.Managers.Remove(tempManager);
                return Update(tempComp);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::RemoveManagerFromCompany::Error occured.", ex);
            }
        }

        public List<Managers> ListManagers(int companyId)
        {
            try
            {
                Companies tempComp = Find(companyId);
                return tempComp.Managers.ToList();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::ListManagers::Error occured.", ex);
            }
        }

        public int AddStaffToCompany(int companyId, int staffId)
        {
            try
            {
                Companies tempComp = Find(companyId);

                StaffRepository tempStaffRepository = new StaffRepository();
                Staffs tempStaff = tempStaffRepository.Find(staffId);

                tempComp.Staffs.Add(tempStaff);
                return Update(tempComp);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::AddStaffToCompany::Error occured.", ex);
            }
        }

        public int RemoveStaffFromCompany(int companyId, int staffId)
        {
            try
            {
                Companies tempComp = Find(companyId);

                StaffRepository tempStaffRepository = new StaffRepository();
                Staffs tempStaff = tempStaffRepository.Find(staffId);

                tempComp.Staffs.Remove(tempStaff);
                return Update(tempComp);
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::RemoveStaffFromCompany::Error occured.", ex);
            }
        }

        public List<Staffs> ListStaff(int companyId)
        {
            try
            {
                Companies tempComp = Find(companyId);
                return tempComp.Staffs.ToList();
            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::ListStaff::Error occured.", ex);
            }
        }

        public int AddRentInfoToCompany(int companyId, RentInfos entity)
        {
            try
            {
                Companies tempComp = Find(companyId);
                tempComp.RentInfos.Add(entity);
                return Update(tempComp);

            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::AddRentInfoToCompany::Error occured.", ex);
            }
        }

        public List<RentInfos> ListRentInfo(int companyId)
        {
            try
            {
                Companies tempComp = Find(companyId);

                return tempComp.RentInfos.ToList();

            }
            catch (Exception ex)
            {

                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("CompanyRepository::ListRentInfo::Error occured.", ex);
            }
        }

    }
}
