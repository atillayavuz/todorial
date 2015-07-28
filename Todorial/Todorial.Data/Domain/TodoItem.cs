using System;
using Todorial.Data.Domain.Abstract;

namespace Todorial.Data.Domain
{
    public class TodoItem :BaseDomainEntity<Guid>
    {
        public Guid TodoItemListId { get; set; }

        public string Content { get; set; }

        public bool IsCompleted { get; set; }
        public bool IsStarred { get; set; }

        public DateTime? DueDate { get; set; }

        public TodoItemList TodoItemList { get; set; }
    }
}
