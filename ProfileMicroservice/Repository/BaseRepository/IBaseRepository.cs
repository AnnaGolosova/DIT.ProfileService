using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> ReturnAll(bool trackChanges);
        IQueryable<T> ReturnDistinct(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}