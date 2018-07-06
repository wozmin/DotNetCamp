using GamesServer.BLL.DTO;


namespace GamesServer.BLL.Interfaces
{
    interface IUserService
    {
        UserDTO GetHighScoreUser();
    }
}
