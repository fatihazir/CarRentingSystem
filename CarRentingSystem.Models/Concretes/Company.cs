using System.Collections.Generic;

namespace CarRentingSystem.Models.Concretes
{
    public class Company
    {
        public Company()
        {
            VehicleList = new List<Vehicle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public ushort OwnedCars { get; set; }
        public byte Point { get; set; }
        public decimal PhoneNumber { get; set; }
        public string PhotoLink { get; set; }

        public List<Vehicle> VehicleList { get; set; }
    }
}