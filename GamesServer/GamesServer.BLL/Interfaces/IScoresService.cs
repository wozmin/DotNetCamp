using System;
using System.Collections.Generic;
using System.Text;
using GamesServer.BLL.DTO;

namespace GamesServer.BLL.Interfaces
{
    public interface IScoresService
    {
        void SaveScores(ScoresDTO result);

        IEnumerable<ScoresDTO> GetScores();
        IEnumerable<ScoresDTO> GetScoresByUser(Guid userId);
        IEnumerable<ScoresDTO> GetScoresByGame(Guid gameId);
        IEnumerable<ScoresDTO> GetScoresByGameUser(Guid userId, Guid gameId);
        void SaveScore(SaveScoreDTO score);
    }
}
