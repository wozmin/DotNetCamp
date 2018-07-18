using System;
using GamesServer.BLL.DTO;
using GamesServer.DAL.Enteties;


namespace GamesServer.BLL.Interfaces
{
    public interface IUserService
    {
        void CreateUser(UserInfoDTO user);
        void DeleteUser(UserInfoDTO user);
        UserDTO HighScoreUser(Guid gameId);
        bool isUserExists(Guid id);

    }
}
