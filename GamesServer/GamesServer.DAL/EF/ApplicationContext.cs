using GamesServer.DAL.Enteties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.DAL.EF
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameUser> GameUsers { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
        }

    }
}
