using Microsoft.EntityFrameworkCore;
using Festivalcompanion.Models;

namespace FestivalCompanion.Data;

public class FestivalCompanionContext(
    DbContextOptions<FestivalCompanionContext> options
) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Festival> Festivals { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
    }
}

