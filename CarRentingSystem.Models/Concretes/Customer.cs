using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Models.Concretes
{
    public class Customer
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CityOfBirth { get; set; }
        public decimal IdentityNumberOfCountry { get; set; }
        public string Address { get; set; }
        public ushort LicenceNumber { get; set; }
        public string BeginningDateOfLicense { get; set; }
        public string EndingDateOfLicense { get; set; }
        public byte YearsOfLicenceUsed { get; set; }

    }
}
