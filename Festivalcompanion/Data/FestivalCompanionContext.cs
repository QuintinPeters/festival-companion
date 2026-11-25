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
}