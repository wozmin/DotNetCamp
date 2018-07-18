using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GamesServer.BLL.DTO;
using GamesServer.BLL.Interfaces;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;

namespace GamesServer.BLL.Services
{
    public class ScoresService:IScoresService
    {
        private IUnitOfWork Database { get; set; }
        private IMapper Mapper { get; set; }
        public ScoresService(IMapper mapper,IUnitOfWork uof)
        {
            Mapper = mapper;
            Database = uof;
        }

        public void SaveScores(ScoresDTO result)
        {
            if (result != null)
            {
                var score =Mapper.Map<ScoresDTO, GameUser>(result);
                Database.GameUsers.Create(score);
                Database.Save();
            }
        }

        public IEnumerable<ScoresDTO> GetScores()
        {
            var scores = Database.GameUsers.GetAll();
            return Mapper.Map<IEnumerable<GameUser>, IEnumerable<ScoresDTO>>(scores);
        }

        public IEnumerable<ScoresDTO> GetScoresByUser(Guid userId)
        {
            var scores = Database.GameUsers.FindByCondition(u => u.UserId == userId);
            return Mapper.Map<IEnumerable<GameUser>, IEnumerable<ScoresDTO>>(scores);
        }

        public IEnumerable<ScoresDTO> GetScoresByGame(Guid gameId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScoresDTO> GetScoresByGameUser(Guid userId, Guid gameId)
        {
            var scores = Database.GameUsers.FindByCondition(u => u.GameId == gameId && u.UserId == userId);
            return Mapper.Map<IEnumerable<GameUser>, IEnumerable<ScoresDTO>>(scores);
        }

        public void SaveScore(SaveScoreDTO score)
        {
            var result = Mapper.Map<SaveScoreDTO, GameUser>(score);
            Database.GameUsers.Create(result);
            if (!Database.Save())
            {
                throw new Exception($"Cannot save results for {result.UserId} from the game {result.GameId}");
            }
        }

    }
}
