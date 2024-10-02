using Microsoft.EntityFrameworkCore;

namespace KartApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Veritabanındaki Locations tablosunu temsil eden DbSet
        public DbSet<Location> Locations { get; set; }
    }

    // Location modeli
    public class Location
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
