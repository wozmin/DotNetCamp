using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GamesServer.DAL.Interfaces
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindByCondition(Expression<Func<T,bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
