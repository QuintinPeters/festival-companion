using Microsoft.EntityFrameworkCore;

namespace FestivalCompanion.Data;

public class FestivalCompanionContext(
    DbContextOptions<FestivalCompanionContext> options
) : DbContext(options)
{
    // Hier komen je database tabellen
}