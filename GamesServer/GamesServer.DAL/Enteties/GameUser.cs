using System;

namespace GamesServer.DAL.Enteties
{
    public class GameUser
    {
        public Guid GameId { get; set; }
        public Game Game { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public DateTime Date { get; set; }

        public int Score { get; set; }
    }
}
