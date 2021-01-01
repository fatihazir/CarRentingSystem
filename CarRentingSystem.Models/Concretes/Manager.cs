using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class Manager : User
    {
        public byte Id { get; set; }
        public List<Staff> StaffList { get; set; }
    }
}
