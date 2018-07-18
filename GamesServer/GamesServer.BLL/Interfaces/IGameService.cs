using System;
using System.Collections.Generic;
using System.Text;
using GamesServer.BLL.DTO;
using GamesServer.DAL.Enteties;

namespace GamesServer.BLL.Interfaces
{
    public interface IGameService
    {
        bool isGameExists(Guid id);
        IEnumerable<GameDTO> getGames();
        void AddGame(CreateGameDTO gameDTO);
    }
}
