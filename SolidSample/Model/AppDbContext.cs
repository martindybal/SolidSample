using Microsoft.EntityFrameworkCore;

namespace SolidSample.Model;

public class AppDbContext : DbContext
{
    public DbSet<AudioBook> AudioBooks { get; set; } = null!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}