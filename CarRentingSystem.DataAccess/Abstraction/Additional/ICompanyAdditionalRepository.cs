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

        int RemoveCarFromCompany(int companyId, int vehicleId);

        List<Vehicles> ListCars(int companyId);

        int AddManagerToCompany(int companyId, int managerId);

        int RemoveManagerFromCompany(int companyId, int managerId);

        List<Managers> ListManagers(int companyId);

        int AddStaffToCompany(int companyId, int staffId);

        int RemoveStaffFromCompany(int companyId, int staffId);

        List<Staffs> ListStaff(int companyId);

        int AddRentInfoToCompany(int companyId, RentInfos entity);

        List<RentInfos> ListRentInfo(int companyId);



    }
}
