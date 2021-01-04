using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Abstraction;
using CarRentingSystem.Models.Concretes;

namespace CarRentingSystem.DataAccess.Concretes
{
    public class RentInfoRepository : IRepositoryMain<RentInfo>, IDisposable
    {
        public bool Insert(RentInfo entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(RentInfo entity)
        {
            throw new NotImplementedException();
        }

        public bool DeletedById(int id)
        {
            throw new NotImplementedException();
        }

        public RentInfo SelectedById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<RentInfo> SelectAll()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
