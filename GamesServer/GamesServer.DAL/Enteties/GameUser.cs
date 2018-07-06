using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.DAL.Enteties
{
    public class GameUser
    {
        public int Id { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
