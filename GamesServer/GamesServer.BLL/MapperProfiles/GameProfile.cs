using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GamesServer.BLL.DTO;
using GamesServer.DAL.Enteties;

namespace GamesServer.BLL.MapperProfiles
{
    class GameProfile:Profile
    {
        public GameProfile()
        {
            CreateMap<IEnumerable<Game>, IEnumerable<GameDTO>>();
            CreateMap<CreateGameDTO, Game>();
        }
    }
}
