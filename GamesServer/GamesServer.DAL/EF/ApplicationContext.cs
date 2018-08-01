using GamesServer.DAL.Enteties;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamesServer.DAL.EF
{
    public class ApplicationContext:IdentityDbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameUser> GameUsers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GameUser>()
                .HasKey(t => new { t.GameId, t.ApplicationUserId });

            modelBuilder.Entity<GameUser>()
                .HasOne(gu => gu.User)
                .WithMany(g => g.GameUsers)
                .HasForeignKey(gu => gu.ApplicationUserId);

            modelBuilder.Entity<GameUser>()
                .HasOne(gu => gu.Game)
                .WithMany(g => g.GameUsers)
                .HasForeignKey(gu => gu.GameId);
        }

    }
}
