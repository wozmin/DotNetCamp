using System;
using System.Linq;
using GamesServer.DAL.EF;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace GamesServer.DAL.Repositories
{
    public class UserRepository :RepositoryBase<User>,IUserRepository
    {
        private ApplicationContext db;
        public UserRepository(ApplicationContext context):base(context)
        {
            db = context;
        }

        public User GetHighScoreUser()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
