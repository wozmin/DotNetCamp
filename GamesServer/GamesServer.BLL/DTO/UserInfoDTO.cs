﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.BLL.DTO
{
    public class UserInfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
