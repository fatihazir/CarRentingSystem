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
            Companies tempComp = Find(entity.Id);
            tempComp = entity;
            return base.Update(tempComp);
        }

        public int RemoveCompanyById(int id)
        {
            Companies tempComp = Find(id);
            return Remove(tempComp);
        }

        public int AddCarToCompany(int companyId, Vehicles entity)
        {
            Companies tempComp = Find(companyId);
            tempComp.Vehicles.Add(entity);
            return Update(tempComp);
        }

        public int RemoveCarFromCompany(int companyId, Vehicles entity)
        {
            Companies tempComp = Find(companyId);
            tempComp.Vehicles.Remove(entity);
            return Update(tempComp);
        }

        public int AddManagerToCompany(int companyId, Managers entity)
        {
            Companies tempComp = Find(companyId);
            tempComp.Managers.Add(entity);
            return Update(tempComp);
        }

        public int RemoveManagerFromCompany(int companyId, Managers entity)
        {
            Companies tempComp = Find(companyId);
            tempComp.Managers.Remove(entity);
            return Update(tempComp);
        }

        public int AddStaffToCompany(int companyId, Staffs entity)
        {
            Companies tempComp = Find(companyId);
            tempComp.Staffs.Add(entity);
            return Update(tempComp);
        }

        public int RemoveStaffFromCompany(int companyId, Staffs entity)
        {
            Companies tempComp = Find(companyId);
            tempComp.Staffs.Remove(entity);
            return Update(tempComp);
        }
    }
}
