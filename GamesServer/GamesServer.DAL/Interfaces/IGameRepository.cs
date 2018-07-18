using System;
using GamesServer.DAL.Enteties;

namespace GamesServer.DAL.Interfaces
{
    public interface IGameRepository:IRepositoryBase<Game>
    {
        Game GetGame(Guid id);
    }
}
