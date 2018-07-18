using System;
using GamesServer.DAL.Enteties;


namespace GamesServer.DAL.Interfaces
{
    public interface IUserRepository :IRepositoryBase<User>
    {
        User GetHighScoreUser(Guid gameId);
        User GetUser(Guid id);
    }
}
