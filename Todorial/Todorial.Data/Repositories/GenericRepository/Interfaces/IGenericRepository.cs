using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Todorial.Data.Domain.Abstract;

namespace Todorial.Data.Repositories
{
    public interface IGenericRepository<T> where T : BaseRepositoryEntity
    {
        T Add(T entity);
        T Delete(T entity);

        void Edit(T entity);
        void Save();

        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
    }
}
