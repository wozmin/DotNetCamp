using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get;}
        IGameRepository Games { get;}
        IGameUserRepository GameUsers { get;}
        void Save();
    }
}
