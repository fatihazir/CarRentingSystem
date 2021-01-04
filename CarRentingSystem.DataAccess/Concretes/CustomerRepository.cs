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
    public class CustomerRepository : IRepositoryMain<Customer>, IDisposable
    {
        public bool Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public bool DeletedById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer SelectedById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
