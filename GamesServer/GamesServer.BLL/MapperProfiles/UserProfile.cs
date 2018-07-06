using AutoMapper;
using GamesServer.BLL.DTO;
using GamesServer.DAL.Enteties;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.BLL.MapperProfiles
{
    class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
