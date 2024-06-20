using Microsoft.EntityFrameworkCore;
using SuperHeroApi8.Entities;

namespace SuperHeroApi8.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<SuperHero> SuperHeroes { get; set; }
}