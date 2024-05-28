
using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } // Do this for every model that you have
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
              
        //Read in our Connection String from our txt file
        string connectionString = File.ReadAllText(@"C:\Users\U88ABJ\Revature\ChanteMovieSQLdb.txt");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasOne(m => m.Renter).WithMany().HasForeignKey();
    }
}