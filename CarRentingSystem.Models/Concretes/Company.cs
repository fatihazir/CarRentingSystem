using System.Collections.Generic;

namespace CarRentingSystem.Models.Concretes
{
    public class Company
    {
        public Company()
        {
            StaffList = new List<Staff>();
            VehicleList = new List<Vehicle>();
            ManagerList = new List<Manager>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public ushort OwnedCars { get; set; }
        public byte Point { get; set; }
        public decimal PhoneNumber { get; set; }
        public int ManagerId { get; set; }

        public List<Manager> ManagerList { get; set; }
        public List<Staff> StaffList { get; set; }
        public List<Vehicle> VehicleList { get; set; }
    }
}