using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace GamesServer.DAL.Enteties
{
    public class ApplicationUser:IdentityUser<string>
    {
        public List<GameUser> GameUsers { get; set; }

        public ApplicationUser()
        {
            GameUsers = new List<GameUser>();
        }
    }
}
