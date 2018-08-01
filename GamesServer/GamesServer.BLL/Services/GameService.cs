using System;
using System.Collections.Generic;
using System.Text;
using GamesServer.BLL.Interfaces;
using GamesServer.DAL.Interfaces;

namespace GamesServer.BLL.Services
{
    class GameService:IGameService
    {
        private readonly IGameRepository _gameRepository;
        public GameService(IGameRepository repository)
        {
            _gameRepository = repository;
        }

        public bool isGameExists(Guid gameId)
        {
            return  _gameRepository.GetGame(gameId) !=null;
        }
    }
}
