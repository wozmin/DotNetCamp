using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GamesServer.DAL.Enteties;
using GamesServer.DAL.Interfaces;

namespace GamesServer.BLL.Interfaces
{
    public interface IAccountService
    {
        string GenerateJwtToken(string email, ApplicationUser user);
        bool IsUserExists(Guid userId);

    }
}
