using F1Network.Models;
using Microsoft.EntityFrameworkCore;

namespace F1Network.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>()
                .HasMany(m => m.Cars)
                .WithOne(c => c.Manufacturer)
                .HasForeignKey(c => c.ManufacturerId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Manufacturer>()
                .HasMany(m => m.Drivers)
                .WithOne(d => d.Manufacturer)
                .HasForeignKey(d => d.ManufacturerId)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
