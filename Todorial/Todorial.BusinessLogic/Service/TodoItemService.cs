using Todorial.BusinessLogic.Common;
using Todorial.BusinessLogic.Service.Interfaces;
using Todorial.Data.Domain;
using Todorial.Data.Repositories.Repository;
using Todorial.Data.UnitofWork;

namespace Todorial.BusinessLogic.Service
{
    public class TodoItemService : EntityService<TodoItem>, ITodoItemService
    {
        #region "Fields"

        IUnitOfWork _unitOfWork;
        ITodoItemRepository _todoItemRepository;
        
        #endregion

        #region "Constructors"

        public TodoItemService(IUnitOfWork unitOfWork, ITodoItemRepository todoItemRepository)
            : base(unitOfWork, todoItemRepository)
        {
            _unitOfWork = unitOfWork;
            _todoItemRepository = todoItemRepository;
        }

        #endregion
    }
}
