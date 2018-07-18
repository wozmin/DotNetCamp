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
   public class GameService:IGameService
   {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork Database;
        public GameService(IUnitOfWork uof,IMapper mapper)
        {
            Database = uof;
        }
        public bool isGameExists(Guid id)
        {
            return Database.Games.GetGame(id) != null;
        }

        public IEnumerable<GameDTO> getGames()
        {
            var games = Database.Games.GetAll();
            return Mapper.Map<IEnumerable<Game>, IEnumerable<GameDTO>>(games);
        }
       

       public void AddGame(CreateGameDTO gameDTO)
       {
           var game = Mapper.Map<CreateGameDTO, Game>(gameDTO);
           Database.Games.Create(game);
           if (!Database.Save())
           {
               throw new Exception($"Can't add game {game.Name} to database");
           }
       }



    }
}
