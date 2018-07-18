using System;
using AutoMapper;
using GamesServer.BLL.DTO;
using GamesServer.BLL.Exceptions;
using GamesServer.BLL.Interfaces;
using GamesServer.DAL.EF;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;

namespace GamesServer.BLL.Services
{
    public class UserService:IUserService
    {
        private  IUnitOfWork Database { get; }
        private  IMapper Mapper { get; }
        public UserService(IUnitOfWork uof,IMapper mapper)
        {
            Database = uof;
            Mapper = mapper;
        }


        public void CreateUser(UserInfoDTO userDTO)
        {
            User user = Mapper.Map<UserInfoDTO, User>(userDTO);
            if (user == null)
            {
                throw new  Exception();
            }
            Database.Users.Create(user);
            Database.Save();
        }

        public void DeleteUser(UserInfoDTO userDTO)
        {
            User user = Mapper.Map<UserInfoDTO, User>(userDTO);
            if (user == null)
            {
                throw new Exception();
            }
            Database.Users.Delete(user);
            Database.Save();
            
        }

        public UserDTO HighScoreUser(Guid gameId)
        {
            User user = Database.Users.GetHighScoreUser(gameId);
            if (user == null)
            {
                throw  new ValidationException("Object is not valid","");
            }

            return Mapper.Map<User,UserDTO>(user);
        }

        public bool isUserExists(Guid id)
        {
            return Database.Users.GetUser(id) != null;
        }

        public UserDTO GetUser(Guid id)
        {
            var user = Database.Users.GetUser(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            return Mapper.Map<User, UserDTO>(user);

        }
    }
}

