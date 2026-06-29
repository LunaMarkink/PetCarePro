using Microsoft.EntityFrameworkCore;
using PetCarePro.Classes;

namespace PetCarePro.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Stay> Stays { get; set; }
    public DbSet<CareSchedule> CareSchedules { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Client>().HasData(
            new Client { ClientId = 1, Name = "Jan Jansen", Address = "Hoofdstraat 1", PhoneNumber = "0612345678", Email = "jan@email.nl" },
            new Client { ClientId = 2, Name = "Piet Pieters", Address = "Dorpsstraat 5", PhoneNumber = "0623456789", Email = "piet@email.nl" },
            new Client { ClientId = 3, Name = "Marie de Vries", Address = "Stationsweg 10", PhoneNumber = "0634567890", Email = "marie@email.nl" },
            new Client { ClientId = 4, Name = "Kees Bakker", Address = "Schoolstraat 15", PhoneNumber = "0645678901", Email = "kees@email.nl" },
            new Client { ClientId = 5, Name = "Sophie Jansen", Address = "Parklaan 8", PhoneNumber = "0656789012", Email = "sophie@email.nl" },
            new Client { ClientId = 6, Name = "Tom Visser", Address = "Molenweg 22", PhoneNumber = "0667890123", Email = "tom@email.nl" }
        );

        modelBuilder.Entity<Pet>().HasData(
            new Pet { PetId = 1, Name = "Max", Species = "Dog", Breed = "Labrador", Gender = "Male", ChipNumber = "123456789", MedicalHistory = "No medical issues", ClientId = 1 },
            new Pet { PetId = 2, Name = "Luna", Species = "Cat", Breed = "European Shorthair", Gender = "Female", ChipNumber = "987654321", MedicalHistory = "Allergic to certain food", ClientId = 2 },
            new Pet { PetId = 3, Name = "Bella", Species = "Dog", Breed = "Golden Retriever", Gender = "Female", ChipNumber = "456789123", MedicalHistory = "Vaccinations up to date", ClientId = 3 },
            new Pet { PetId = 4, Name = "Milo", Species = "Cat", Breed = "Maine Coon", Gender = "Male", ChipNumber = "321654987", MedicalHistory = "Needs daily medication", ClientId = 4 },
            new Pet { PetId = 5, Name = "Rocky", Species = "Dog", Breed = "German Shepherd", Gender = "Male", ChipNumber = "654987321", MedicalHistory = "No medical issues", ClientId = 5 },
            new Pet { PetId = 6, Name = "Nala", Species = "Cat", Breed = "British Shorthair", Gender = "Female", ChipNumber = "789123456", MedicalHistory = "Sensitive stomach", ClientId = 6 }
        );
    }
}