﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.BLL.DTO
{
    public class ScoresByUserDTO
    {
        public string Game { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}
