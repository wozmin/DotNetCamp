using System;
using System.Linq;
using GamesServer.DAL.EF;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamesServer.DAL.Repositories
{
    public class GameRepository :RepositoryBase<Game>,IGameRepository
    {
        private  ApplicationContext db { get; }
        public GameRepository(ApplicationContext context):base(context)
        {
            db = context;
        }


        public Game GetGame(Guid id)
        {
            return db.Games.FirstOrDefault(g => g.Id == id);
        }
    }
}
