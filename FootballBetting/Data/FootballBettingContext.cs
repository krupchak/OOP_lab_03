using FootballBetting.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext(DbContextOptions<FootballBettingContext> options)
        : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().HasMany(c => c.PrimaryKitTeams)
                                        .WithOne(t => t.PrimaryKitColor)
                                        .HasForeignKey(t => t.PrimaryKitColorId)
                                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Color>().HasMany(c => c.SecondaryKitTeams)
                                       .WithOne(t => t.SecondaryKitColor)
                                       .HasForeignKey(t => t.SecondaryKitColorId)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Team>().HasMany(c => c.HomeGames)
                                     .WithOne(t => t.HomeTeam)
                                     .HasForeignKey(t => t.HomeTeamId)
                                     .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Team>().HasMany(c => c.AwayGames)
                                      .WithOne(t => t.AwayTeam)
                                      .HasForeignKey(t => t.AwayTeamId)
                                      .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
