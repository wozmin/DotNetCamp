
using GamesServer.DAL.EF;
using GamesServer.DAL.Interfaces;

namespace GamesServer.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGameRepository _games;
        private IGameUserRepository _gameUsers;
        private ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
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

        public bool Save()
        {
           return _context.SaveChanges() >= 0;
        }
    }
}
