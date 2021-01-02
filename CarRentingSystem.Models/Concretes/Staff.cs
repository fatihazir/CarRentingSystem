using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class Staff : User
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
