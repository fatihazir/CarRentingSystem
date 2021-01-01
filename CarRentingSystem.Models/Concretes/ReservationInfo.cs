using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class ReservationInfo
    {
        public byte Id { get; set; }
        public DateTime BeginningOfRenting { get; set; }
        public DateTime EndingOfRenting { get; set; }
        public ushort PriceOfRenting { get; set; }
        public byte VehicleId { get; set; }
        public byte CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
