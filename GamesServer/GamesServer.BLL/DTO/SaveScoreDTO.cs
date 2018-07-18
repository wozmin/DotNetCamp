using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.BLL.DTO
{
    public class SaveScoreDTO
    {
        public Guid GameId { get; set; }
        public Guid UserId { get; set; }
        public int Score { get; set; }
    }
}
