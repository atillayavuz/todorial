using System.Data.Entity;
using Todorial.Data.Domain;

namespace Todorial.Data.Repositories.Repository
{
    public class TodoItemRepository : GenericRepository<TodoItem>, ITodoItemRepository
    {
        #region "Constructors"

        public TodoItemRepository(DbContext context)
            : base(context)
        {

        }

        #endregion
    }
}
