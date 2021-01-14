using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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
            catch (Exception)
            {

                throw;
            }
        }

        //public List<Companies> ListCompanies(Expression<Func<Companies, bool>> expression)
        //{
        //    try
        //    {
        //        CompanyRepository repo = new CompanyRepository();
        //        return repo.ListAll(expression);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public Companies FindCompany(int id)
        {
            try
            {
                CompanyRepository repo = new CompanyRepository();
                return repo.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public Companies FindCompany(Expression<Func<Companies, bool>> expression)
        //{
        //    try
        //    {
        //        CompanyRepository repo = new CompanyRepository();
        //        return repo.Find(expression);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

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
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddCar(int companyId, Vehicles entity)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.AddCarToCompany(companyId, entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool RemoveCar(int companyId, Vehicles entity)
        {
            //Car repoya ulasıp o arabayı da sil.
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.RemoveCarFromCompany(companyId, entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
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
                CompanyRepository repo = new CompanyRepository();
                return repo.ListCars(companyId);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool AddManager(int companyId, Managers entity)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.AddManagerToCompany(companyId, entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool RemoveManager(int companyId, Managers entity)
        {
            //manager repoya ulasıp managerı da sil.
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.RemoveManagerFromCompany(companyId, entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
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
                CompanyRepository repo = new CompanyRepository();
                return repo.ListManagers(companyId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddStaff(int companyId, Staffs entity)
        {
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.AddStaffToCompany(companyId, entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool RemoveStaff(int companyId, Staffs entity)
        {
            //manager repoya ulasıp managerı da sil.
            try
            {
                bool isSuccess;

                CompanyRepository repo = new CompanyRepository();
                int result = repo.RemoveStaffFromCompany(companyId, entity);

                _ = result == 1 ? isSuccess = true : isSuccess = false;

                return isSuccess;
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
                CompanyRepository repo = new CompanyRepository();
                return repo.ListStaff(companyId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
