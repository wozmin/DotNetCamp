using GamesServer.DAL.EF;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.DAL.Repositories
{
    public class GameRepository :RepositoryBase<Game>,IGameRepository
    {
        public GameRepository(ApplicationContext context):base(context)
        {
        }
    }
}
