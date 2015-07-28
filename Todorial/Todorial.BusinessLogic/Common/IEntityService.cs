using System.Collections.Generic;
using Todorial.Data.Domain.Abstract;

namespace Todorial.BusinessLogic.Common
{
    public interface IEntityService<T>
     where T : BaseRepositoryEntity
    {
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);

        IEnumerable<T> GetAll();
    }
}
