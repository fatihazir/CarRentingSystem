namespace CarRentingSystem.Models.Concretes
{
    public abstract class User : Human
    {
        public int Id { get; set; }
        public ushort Salary { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}