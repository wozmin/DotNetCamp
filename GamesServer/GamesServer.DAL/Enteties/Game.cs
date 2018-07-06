using System.Collections.Generic;

namespace GamesServer.DAL.Enteties
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<GameUser> GameUsers { get; set; }

        public Game()
        {
            GameUsers = new List<GameUser>();
        }
    }
}
