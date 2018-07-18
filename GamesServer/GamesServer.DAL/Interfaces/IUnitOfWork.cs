namespace GamesServer.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get;}
        IGameRepository Games { get;}
        IGameUserRepository GameUsers { get;}
        bool Save();
    }
}
