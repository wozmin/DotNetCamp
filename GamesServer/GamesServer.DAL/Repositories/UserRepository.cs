﻿using GamesServer.DAL.EF;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;


namespace GamesServer.DAL.Repositories
{
    class UserRepository:RepositoryBase<User>,IUserRepository
    {
        public UserRepository(ApplicationContext context):base(context)
        {
        }
    }
}