using Microsoft.EntityFrameworkCore;
using KartApplication.Models;
using KartverketWebApplication.ViewModels;

namespace KartApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

         //Veritabanındaki Locations tablosunu temsil eden DbSet
        public DbSet<Location> Locations { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<RegisterViewModels> RegisterViewModels { get; set; }


    }
}

