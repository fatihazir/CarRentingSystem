using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentingSystem.DataAccess.Entity;

namespace CarRentingSystem.DataAccess.Abstraction.Additional
{
    public interface ICompanyAdditionalRepository
    {
        int AddCarToCompany(int companyId, Vehicles entity);

        int RemoveCarFromCompany(int companyId, Vehicles entity);

        List<Vehicles> ListCars(int companyId);

        int AddManagerToCompany(int companyId, Managers entity);

        int RemoveManagerFromCompany(int companyId, Managers entity);

        List<Managers> ListManagers(int companyId);

        int AddStaffToCompany(int companyId, Staffs entity);

        int RemoveStaffFromCompany(int companyId, Staffs entity);

        List<Staffs> ListStaff(int companyId);

    }
}
