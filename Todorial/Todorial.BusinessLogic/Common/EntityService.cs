using System;
using System.Collections.Generic;
using Todorial.Data.Domain.Abstract;
using Todorial.Data.Repositories;
using Todorial.Data.UnitofWork;

namespace Todorial.BusinessLogic.Common
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        #region "Fields"

        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        #endregion
        
        #region "Constructors"

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        #endregion

        #region "Methods"

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Add(entity);

            _unitOfWork.Commit();
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Edit(entity);

            _unitOfWork.Commit();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _repository.Delete(entity);

            _unitOfWork.Commit();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }
    
        #endregion
    }
}
