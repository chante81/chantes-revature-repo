using Microsoft.EntityFrameworkCore;
using EFCoreExample.Models;

namespace EFCoreExample.Data
{
    public class AppDbContext : DbContext
    {
        // This constructor is used by EF to create teh needed DB Context based on our provided models
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // we provide the models through DbSet<ModelName> fields
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One-to-one relationship
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId);

            // One-to-many relationship
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
