using AutoMapper;
using GamesServer.BLL.DTO;
using GamesServer.DAL.Enteties;

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
