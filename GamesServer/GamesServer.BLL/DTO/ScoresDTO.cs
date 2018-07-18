using System;
using System.Collections.Generic;
using System.Text;
using GamesServer.DAL.Enteties;

namespace GamesServer.BLL.DTO
{
    public class ScoresDTO
    {
        public string User { get; set; }

        public DateTime Date { get; set; }

        public int Score { get; set; }
    }
}
