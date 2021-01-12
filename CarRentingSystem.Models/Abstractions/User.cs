using System.Security.AccessControl;

namespace CarRentingSystem.Models.Concretes
{
    public abstract class User : Human
    {
        public int Id { get; set; }
        public ushort Salary { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhotoLink { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}