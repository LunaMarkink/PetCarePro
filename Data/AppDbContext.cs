using Microsoft.EntityFrameworkCore;
using PetCarePro.Classes;

namespace PetCarePro.Data
{
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
    }
}