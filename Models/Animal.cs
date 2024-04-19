using System.Diagnostics.CodeAnalysis;

namespace Vet_Clinic.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } 
        public required string Category { get; set; }
        public double Weight { get; set; }
        public string? FurColor { get; set; }
    }
}
