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
            CompanyRepository repo = new CompanyRepository();
            return repo.ListAll();
        }

        public List<Companies> ListCompanies(Expression<Func<Companies, bool>> expression)
        {
            CompanyRepository repo = new CompanyRepository();
            return repo.ListAll(expression);
        }

        public Companies FindCompany(int id)
        {
            CompanyRepository repo = new CompanyRepository();
            return repo.Find(id);
        }

        public Companies FindCompany(Expression<Func<Companies, bool>> expression)
        {
            CompanyRepository repo = new CompanyRepository();
            return repo.Find(expression);
        }

        public bool InsertCompany(Companies entity)
        {
            bool isSuccess;

            CompanyRepository repo = new CompanyRepository();
            int result =  repo.Insert(entity);
            
            _ = result == 1 ? isSuccess = true : isSuccess = false;

            return isSuccess;
        }

        public bool UpdateCompany(Companies entity)
        {
            bool isSuccess;

            CompanyRepository repo = new CompanyRepository();
            int result = repo.Update(entity);

            _ = result == 1 ? isSuccess = true : isSuccess = false;

            return isSuccess;
        }

        public bool RemoveCompany(int id)
        {
            bool isSuccess;

            CompanyRepository repo = new CompanyRepository();
            int result = repo.RemoveCompanyById(id);

            _ = result == 1 ? isSuccess = true : isSuccess = false;

            return isSuccess;
        }

        public bool AddCar(int companyId, Vehicles entity)
        {
            bool isSuccess;

            CompanyRepository repo = new CompanyRepository();
            int result = repo.AddCarToCompany(companyId, entity);

            _ = result == 1 ? isSuccess = true : isSuccess = false;

            return isSuccess;
        }

        public bool RemoveCar(int companyId, Vehicles entity)
        {
            bool isSuccess;

            CompanyRepository repo = new CompanyRepository();
            int result = repo.RemoveCarFromCompany(companyId, entity);

            _ = result == 1 ? isSuccess = true : isSuccess = false;

            return isSuccess;
        }

        public bool AddManager(int companyId, Managers entity)
        {
            bool isSuccess;

            CompanyRepository repo = new CompanyRepository();
            int result = repo.AddManagerToCompany(companyId, entity);

            _ = result == 1 ? isSuccess = true : isSuccess = false;

            return isSuccess;
        }

        public bool RemoveManager(int companyId, Managers entity)
        {
            bool isSuccess;

            CompanyRepository repo = new CompanyRepository();
            int result = repo.RemoveManagerFromCompany(companyId, entity);

            _ = result == 1 ? isSuccess = true : isSuccess = false;

            return isSuccess;
        }
    }
}
