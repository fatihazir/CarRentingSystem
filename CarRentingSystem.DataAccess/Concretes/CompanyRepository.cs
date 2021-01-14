using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            catch (Exception)
            {

                throw;
            }
        }

        public int RemoveCompanyById(int id)
        {
            try
            {
                Companies tempComp = Find(id);
                return Remove(tempComp);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AddCarToCompany(int companyId, int vehicleId)
        {
            try
            {
                Companies tempComp = Find(companyId);

                VehicleRepository tempVehicleRepository = new VehicleRepository();
                Vehicles tempCar = tempVehicleRepository.Find(vehicleId);

                tempComp.Vehicles.Add(tempCar);
                return Update(tempComp);
            }
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }

        public List<Vehicles> ListCars(int companyId)
        {
            try
            {
                Companies tempComp = Find(companyId);
                return tempComp.Vehicles.ToList();
            }
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }

        public List<Managers> ListManagers(int companyId)
        {
            try
            {
                Companies tempComp = Find(companyId);
                return tempComp.Managers.ToList();
            }
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }

        public List<Staffs> ListStaff(int companyId)
        {
            try
            {
                Companies tempComp = Find(companyId);
                return tempComp.Staffs.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
