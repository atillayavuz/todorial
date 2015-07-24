using System;
using System.Data.Entity;

namespace Todorial.Data.UnitofWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        #region "Fields"

        private DbContext _dbContext;

        #endregion

        #region "Constructors"

        public UnitOfWork(DbContext context)
        {
            _dbContext = context;
        }

        #endregion

        #region "Methods"

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }

        #endregion
    }
}
