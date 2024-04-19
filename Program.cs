using Vet_Clinic.DB;
using Vet_Clinic.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/animals", () => Database.Animals);

app.MapGet("/animals/{id}", (Guid id) => Database.Animals.FirstOrDefault(a => a.Id == id));

app.MapPost("/animals", (Animal animal) => {
    animal.Id = Guid.NewGuid();
    Database.Animals.Add(animal);
    return Results.Created($"/animals/{animal.Id}", animal);
});

app.MapPut("/animals/{id}", (Guid id, Animal updatedAnimal) => {
    var animal = Database.Animals.FirstOrDefault(a => a.Id == id);
    if (animal == null) return Results.NotFound();
    animal.Name = updatedAnimal.Name;
    animal.Category = updatedAnimal.Category;
    animal.Weight = updatedAnimal.Weight;
    animal.FurColor = updatedAnimal.FurColor;
    return Results.NoContent();
});

app.MapDelete("/animals/{id}", (Guid id) => {
    var animal = Database.Animals.FirstOrDefault(a => a.Id == id);
    if (animal == null) return Results.NotFound();
    Database.Animals.Remove(animal);
    return Results.NoContent();
});

app.MapGet("/animals/{animalId}/visits", (Guid animalId) =>
    Database.Visits.Where(v => v.AnimalId == animalId).ToList());

app.MapPost("/visits", (Visit visit) => {
    visit.Id = Guid.NewGuid();
    Database.Visits.Add(visit);
    return Results.Created($"/visits/{visit.Id}", visit);
});

app.Run();
