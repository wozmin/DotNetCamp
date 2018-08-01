using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.BLL.Interfaces
{
    public interface IGameService
    {
        bool isGameExists(Guid gameId);
    }
}
