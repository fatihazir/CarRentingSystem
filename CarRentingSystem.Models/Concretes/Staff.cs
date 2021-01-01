using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class Staff : User
    {
        public byte Id { get; set; }
        public byte ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}
