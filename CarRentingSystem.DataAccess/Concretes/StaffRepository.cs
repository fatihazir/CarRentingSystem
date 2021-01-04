using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class StaffRepository : IRepositoryMain<Staff>, IDisposable
    {
        public bool Insert(Staff entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Staff entity)
        {
            throw new NotImplementedException();
        }

        public bool DeletedById(int id)
        {
            throw new NotImplementedException();
        }

        public Staff SelectedById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Staff> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
