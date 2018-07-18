using System;
using System.Collections.Generic;
using System.Linq;
using GamesServer.DAL.EF;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;

namespace GamesServer.DAL.Repositories
{
    public class GameUserRepository :RepositoryBase<GameUser>,IGameUserRepository
    {
        private readonly ApplicationContext db;
        public GameUserRepository(ApplicationContext context):base(context)
        {
            db = context;
        }
    }
}
