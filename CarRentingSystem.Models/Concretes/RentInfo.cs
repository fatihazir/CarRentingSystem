using System;

namespace CarRentingSystem.Models.Concretes
{
    public class RentInfo
    {
        public int Id { get; set; }
        public ushort BeginningKmOfVehicle { get; set; }
        public ushort EndingKmOfVehicle { get; set; }
        public bool ReqPending { get; set; }
        public DateTime BeginningOfRenting { get; set; }
        public DateTime EndingOfRenting { get; set; }
        public ushort PriceOfRenting { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}