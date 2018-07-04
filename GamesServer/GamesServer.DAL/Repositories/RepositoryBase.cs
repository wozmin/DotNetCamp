using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GamesServer.DAL.EF;
using GamesServer.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamesServer.DAL.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public ApplicationContext Db { get; set; }

        public RepositoryBase(ApplicationContext context)
        {
            Db = context;
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return Db.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>();
        }

        public void Create(T entity)
        {
            Db.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            Db.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
        }
    }
}
