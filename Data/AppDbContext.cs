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
    public DbSet<Cage> Cages { get; set; }
    public DbSet<Reservation> Reservations { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Cage>()
        .Property(c => c.Size)
        .HasConversion<string>();

    base.OnModelCreating(modelBuilder);
}
}