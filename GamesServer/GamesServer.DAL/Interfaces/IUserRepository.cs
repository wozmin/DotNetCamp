using GamesServer.DAL.Enteties;


namespace GamesServer.DAL.Interfaces
{
    public interface IUserRepository :IRepositoryBase<User>
    {
        User GetHighScoreUser();
        User GetUser(int id);
    }
}
