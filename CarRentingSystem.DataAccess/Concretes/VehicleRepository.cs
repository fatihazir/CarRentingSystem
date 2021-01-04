using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class VehicleRepository : IRepositoryMain<Vehicle>, IDisposable
    {
        public bool Insert(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public bool DeletedById(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle SelectedById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Vehicle> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
