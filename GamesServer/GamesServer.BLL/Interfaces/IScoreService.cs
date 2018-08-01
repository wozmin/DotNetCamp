using System;
using System.Collections.Generic;
using System.Text;
using GamesServer.BLL.DTO;

namespace GamesServer.BLL.Interfaces
{
    public interface IScoreService
    {
        void SaveScore(SaveScoreDTO scoreDTO);
        IEnumerable<ScoresByGameDTO> GetScoresByGame(Guid gameId);
        IEnumerable<ScoresByUserDTO> GetScoresByUser(string userId);
    }
}
