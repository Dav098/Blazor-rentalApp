using Microsoft.EntityFrameworkCore;
using RentalApp.Entities;

namespace RentalApp.Data
{
    public class RentalDbContext : DbContext
    {
        public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options) {}

        public DbSet<Client> Clients { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Log> Logs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(c => c.Id);
            modelBuilder.Entity<Equipment>().HasKey(e => e.Id);
            modelBuilder.Entity<Rental>().HasKey(r => r.Id);

            modelBuilder.Entity<Equipment>()
                .Property(e => e.IsAvailable)
                .HasDefaultValue(true);
        }
    }
}
