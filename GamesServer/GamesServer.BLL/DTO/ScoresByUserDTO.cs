using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.BLL.DTO
{
    class ScoresByUserDTO
    {
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}
