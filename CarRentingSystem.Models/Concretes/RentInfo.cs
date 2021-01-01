using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class RentInfo : ReservationInfo
    {
        public ushort BeginningKmOfVehicle { get; set; }
        public ushort EndingKmOfVehicle { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        

    }
}
