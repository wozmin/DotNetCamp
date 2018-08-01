using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GamesServer.BLL.DTO;
using GamesServer.BLL.Interfaces;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;

namespace GamesServer.BLL.Services
{
    public class ScoreService:IScoreService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _mapper; 
        public ScoreService(IMapper mapper,IUnitOfWork db)
        {
            _db = db;
            _mapper = mapper;
        }

        public void SaveScore(SaveScoreDTO scoreDTO)
        {
            var score = Mapper.Map<SaveScoreDTO, GameUser>(scoreDTO);
            _db.GameUsers.Create(score);
            if (!_db.Save())
            {
                throw new Exception($"Score for user {scoreDTO.UserId} not saved");
            }
            
        }

        public IEnumerable<ScoresByGameDTO> GetScoresByGame(Guid gameId)
        {
            var scores = _db.GameUsers.GetAll().Where(g => g.GameId == gameId);
            return _mapper.Map<IEnumerable<GameUser>, IEnumerable<ScoresByGameDTO>>(scores);
        }

        public IEnumerable<ScoresByUserDTO> GetScoresByUser(string userId)
        {
            var scores = _db.GameUsers.GetAll().Where(u => u.ApplicationUserId == userId);
            return _mapper.Map<IEnumerable<GameUser>, IEnumerable<ScoresByUserDTO>>(scores);
        }
    }
}
