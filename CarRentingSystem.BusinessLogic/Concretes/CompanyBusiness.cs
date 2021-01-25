using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.Commons.Concretes.Helpers;
using CarRentingSystem.Commons.Concretes.Logger;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DataAccess.Concretes;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.BusinessLogic.Concretes
{
    public class CompanyBusiness : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        public List<Companies> ListCompanies()
        {
            try
            {
                CompanyRepository repo = new CompanyRepository();
                return repo.ListAll();
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::List::Error occured.", ex);
            }
        }


        public Companies FindCompany(int id)
        {
            try
            {
                CompanyRepository repo = new CompanyRepository();
                return repo.Find(id);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::FindCompany::Error occured.", ex);
            }
        }

        public bool InsertCompany(Companies entity)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.Insert(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::InsertCompany::Error occured.", ex);
            }
        }

        public bool UpdateCompany(Companies entity)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.Update(entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::UpdateCompany::Error occured.", ex);
            }
        }

        public bool RemoveCompany(int id)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.RemoveCompanyById(id);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::RemoveCompany::Error occured.", ex);
            }
        }

        public bool AddCar(int companyId, Vehicles entity)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.AddCarToCompany(companyId,entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::AddCar::Error occured.", ex);
            }
        }

        public bool RemoveCar(int companyId, int vehicleId)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.RemoveCarFromCompany(companyId, vehicleId);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::RemoveCar::Error occured.", ex);
            }
        }

        public List<Vehicles> ListCars(int companyId)
        {
            try
            {
                CompanyRepository repo = new CompanyRepository();
                return repo.ListCars(companyId);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::ListCars::Error occured.", ex);
            }
        }

        public bool AddManager(int companyId, int managerId)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.AddManagerToCompany(companyId, managerId);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::AddManager::Error occured.", ex);
            }
        }

        public bool RemoveManager(int companyId, int managerId)
        {
            
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.RemoveManagerFromCompany(companyId, managerId);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::RemoveManager::Error occured.", ex);
            }
        }

        public List<Managers> ListManagers(int companyId)
        {
            try
            {
                CompanyRepository repo = new CompanyRepository();
                return repo.ListManagers(companyId);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::ListManagers::Error occured.", ex);
            }
        }

        public bool AddStaff(int companyId, int staffId)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.AddStaffToCompany(companyId, staffId);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::AddStaff::Error occured.", ex);
            }
        }

        public bool RemoveStaff(int companyId, int staffId)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.RemoveStaffFromCompany(companyId, staffId);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::RemoveStaff::Error occured.", ex);
            }
        }

        public List<Staffs> ListStaff(int companyId)
        {
            try
            {
                CompanyRepository repo = new CompanyRepository();
                return repo.ListStaff(companyId);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::ListStaff::Error occured.", ex);
            }
        }

        public bool AddRentnfo(int companyId, RentInfos entity)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.AddRentInfoToCompany(companyId, entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::AddRentInfo::Error occured.", ex);
            }
        }

        public List<RentInfos> ListRentInfos(int companyId)
        {
            try
            {
                CompanyRepository repo = new CompanyRepository();
                return repo.ListRentInfo(companyId);
            }
            catch (Exception ex)
            {
                LogHelper.Log(LogTarget.File, ExceptionHelper.ExceptionToString(ex), true);
                throw new Exception("BusinessLogic::CompanyBusiness::ListRentInfos::Error occured.", ex);
            }
        }
    }
}
