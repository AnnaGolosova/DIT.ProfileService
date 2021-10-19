using Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ProfileContext _context;
        public BaseRepository(ProfileContext context)
        {
            _context = context;
        }
        public IQueryable<T> ReturnAll(bool trackChanges) => !trackChanges ?
            _context.Set<T>().AsNoTracking() : _context.Set<T>();

        public IQueryable<T> ReturnDistinct(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ?
            _context.Set<T>().Where(expression).AsNoTracking() : _context.Set<T>().Where(expression);

        public void Create(T entity) 
        { 
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {

            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
