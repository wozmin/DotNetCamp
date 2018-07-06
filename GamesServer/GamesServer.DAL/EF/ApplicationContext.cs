using GamesServer.DAL.Enteties;
using Microsoft.EntityFrameworkCore;

namespace GamesServer.DAL.EF
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameUser> GameUsers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameUser>()
                .HasKey(t => new { t.GameId, t.UserId });

            modelBuilder.Entity<GameUser>()
                .HasOne(gu => gu.User)
                .WithMany(g => g.GameUsers)
                .HasForeignKey(gu => gu.UserId);

            modelBuilder.Entity<GameUser>()
                .HasOne(gu => gu.Game)
                .WithMany(g => g.GameUsers)
                .HasForeignKey(gu => gu.GameId);
        }

    }
}
