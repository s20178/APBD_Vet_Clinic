namespace Vet_Clinic.Models
{
    public class Visit
    {
        public Guid Id { get; set; }
        public Guid AnimalId { get; set; }
        public DateTime DateOfVisit { get; set; }
        public required string Description { get; set; }
        public decimal Cost { get; set; }
    }
}
