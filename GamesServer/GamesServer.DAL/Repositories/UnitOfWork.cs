using GamesServer.DAL.EF;
using GamesServer.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesServer.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserRepository _users;
        private IGameRepository _games;
        private IGameUserRepository _gameUsers;
        private ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public IUserRepository Users {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context);
                }
                return _users;
            }
        }
        public IGameRepository Games {
            get {
                if(_games == null)
                {
                    _games = new GameRepository(_context);
                }
                return _games;
            }
        }

        public IGameUserRepository GameUsers {
            get
            {
                if(_gameUsers == null)
                {
                    _gameUsers = new GameUserRepository(_context);
                }
                return _gameUsers;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
