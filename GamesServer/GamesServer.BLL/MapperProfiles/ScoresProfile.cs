using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GamesServer.BLL.DTO;
using GamesServer.DAL.Enteties;

namespace GamesServer.BLL.MapperProfiles
{
    public class ScoresProfile:Profile
    {
        public ScoresProfile()
        {
            CreateMap<GameUser, ScoresDTO>();
            CreateMap<ScoresDTO, GameUser>();
            CreateMap<IEnumerable<GameUser>, IEnumerable<ScoresDTO>>();
            CreateMap<SaveScoreDTO, GameUser>().ForMember(gu=>gu.Date,val=>new DateTime());
            CreateMap<GameUser, ScoresByUserDTO>();
            CreateMap<GameUser, ScoresByGameDTO>();
        }
    }
}
