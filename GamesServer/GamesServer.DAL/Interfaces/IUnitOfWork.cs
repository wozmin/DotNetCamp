namespace GamesServer.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGameRepository Games { get;}
        IGameUserRepository GameUsers { get;}
        bool Save();
    }
}
