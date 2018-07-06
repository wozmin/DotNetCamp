using GamesServer.BLL.DTO;
using GamesServer.DAL.Enteties;


namespace GamesServer.BLL.Interfaces
{
    public interface IUserService
    {
        void CreateUser(User user);
        void DeleteUser(User user);
        UserDTO GetUser(int id);

    }
}
