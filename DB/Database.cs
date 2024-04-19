using Vet_Clinic.Models;

namespace Vet_Clinic.DB
{
    public class Database
    {
        public static List<Animal> Animals = new List<Animal>
    {
        new Animal { Id = Guid.NewGuid(), Name = "Fafik", Category = "Pies", Weight = 15.0, FurColor = "Czarny" },
        new Animal { Id = Guid.NewGuid(), Name = "Miau", Category = "Kot", Weight = 4.5, FurColor = "Szary" },
        new Animal { Id = Guid.NewGuid(), Name = "Chrumek", Category = "Świnia", Weight = 120.0, FurColor = "Różowy" }
    };

        public static List<Visit> Visits = new List<Visit>
    {
        new Visit { Id = Guid.NewGuid(), AnimalId = Animals[0].Id, DateOfVisit = DateTime.Now.AddDays(-10), Description = "Roczne szczepienie", Cost = 150.00M },
        new Visit { Id = Guid.NewGuid(), AnimalId = Animals[1].Id, DateOfVisit = DateTime.Now.AddDays(-1), Description = "Kontrolne badanie", Cost = 100.00M },
        new Visit { Id = Guid.NewGuid(), AnimalId = Animals[2].Id, DateOfVisit = DateTime.Now.AddDays(-30), Description = "Operacja", Cost = 1200.00M }
    };
    }
}
