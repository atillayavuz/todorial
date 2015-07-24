using System.Collections.Generic;
using Todorial.Data.Domain.Abstract;

namespace Todorial.BusinessLogic.Common
{
    public interface IEntityService<T>
     where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T entity); 
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
