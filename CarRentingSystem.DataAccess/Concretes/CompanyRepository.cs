using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.DBCreator;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class CompanyRepository : IRepositoryMain<Company>, IDisposable
    {
        public bool Insert(Company entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Company entity)
        {
            throw new NotImplementedException();
        }

        public bool DeletedById(int id)
        {
            throw new NotImplementedException();
        }

        public Company SelectedById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Company> SelectAll()
        {
            DataContext db = new DataContext();
            List<Company> companies = db.Companies.ToList();
            return companies;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
