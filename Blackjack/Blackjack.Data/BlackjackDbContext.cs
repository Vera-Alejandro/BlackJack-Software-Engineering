using Microsoft.EntityFrameworkCore;

namespace Blackjack.Data
{
    public class BlackjackDbContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Hand> Hand { get; set; }
        public DbSet<Card> Card { get; set; }
    }
}