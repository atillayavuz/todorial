﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Todorial.Data.Domain.Abstract;

namespace Todorial.Data.Repositories
{

    public abstract class GenericRepository<T> : IGenericRepository<T>
          where T : BaseRepositoryEntity
    {
        #region "Fields"

        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;

        #endregion

        #region "Constructors"

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        #endregion

        #region "Methods"
       
        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {

            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        #endregion
    }
}
