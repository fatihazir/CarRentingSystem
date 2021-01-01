using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class Vehicle
    {
        public Vehicle()
        {
            PrevRentList = new List<RentInfo>();
        }
        public int Id { get; set; }
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public ushort ModelYear { get; set; }
        public string Plate { get; set; }
        public byte RequiredOldForLicence { get; set; }
        public ushort PriceOfRenting { get; set; }
        public byte MinimumAgeLimit { get; set; }
        public ushort DailyKmMax { get; set; }
        public ushort CurrentKm { get; set; }
        public bool HaveAirbag { get; set; }
        public byte VolumeOfLuggage { get; set; }
        public byte AmountOfSeat { get; set; }
        public ushort DailyRentPrice { get; set; }
        public int CompanyId { get; set; }

        public Company Company { get; set; }
        public List<RentInfo> PrevRentList { get; set; }

    }
}
