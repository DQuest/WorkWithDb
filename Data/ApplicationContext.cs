using Microsoft.EntityFrameworkCore;
using WorkWithDatabase.Models;

namespace WorkWithDatabase.Data;


public class ApplicationContext : DbContext
{
    public DbSet<City> Cities => Set<City>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Animal> Animals => Set<Animal>();

    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=WorkWithDatabase.db");
    }
}