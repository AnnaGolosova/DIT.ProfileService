using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public interface IBaseRepository<T> where T : class
    {
        void Create(T entity);
        void Delete(T entity);
        IQueryable<T> ReturnAll(bool trackChanges);
        IQueryable<T> ReturnDistinct(Expression<Func<T, bool>> expression, bool trackChanges);
        void Update(T entity);
    }
}