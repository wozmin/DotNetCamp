using System;
using System.Collections.Generic;

namespace GamesServer.DAL.Enteties
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<GameUser> GameUsers { get; set; }

        public User()
        {
            GameUsers = new List<GameUser>();
        }
    }
}
