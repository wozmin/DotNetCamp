namespace GamesServer.DAL.Enteties
{
    public class GameUser
    {
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int Score { get; set; }
    }
}
