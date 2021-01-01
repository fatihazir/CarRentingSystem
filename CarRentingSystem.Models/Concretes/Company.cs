using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class Company
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public ushort OwnedCars { get; set; }
        public byte Point { get; set; }
        public decimal PhoneNumber { get; set; }
        public byte ManagerId { get; set; }



        public Manager Manager { get; set; }
        public List<Staff> StaffList { get; set; }

    }
}
