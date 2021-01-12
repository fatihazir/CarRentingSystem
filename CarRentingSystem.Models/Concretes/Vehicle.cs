namespace CarRentingSystem.Models.Concretes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public ushort ModelYear { get; set; }
        public string Plate { get; set; }
        public byte RequiredOldForLicence { get; set; }
        public byte MinimumAgeLimit { get; set; }
        public ushort DailyKmMax { get; set; }
        public int CurrentKm { get; set; }
        public bool HaveAirbag { get; set; }
        public ushort VolumeOfLuggage { get; set; }
        public byte AmountOfSeat { get; set; }
        public ushort DailyRentPrice { get; set; }
        public string PhotoLink { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}