using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public abstract class User : Customer
    {
        public ushort Salary { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public bool CanEditContents { get; set; }

    }
}
