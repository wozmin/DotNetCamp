using GamesServer.DAL.EF;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;

namespace GamesServer.DAL.Repositories
{
    public class GameUserRepository :RepositoryBase<GameUser>,IGameUserRepository
    {
        public GameUserRepository(ApplicationContext context):base(context)
        {
        }
    }
}
