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
    public class CompanyRepository : MainRepository<Companies>, ICompanyAdditionalRepository
    {
        public void CompanyTest()
        {
            var x = 10;
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
    }
}
