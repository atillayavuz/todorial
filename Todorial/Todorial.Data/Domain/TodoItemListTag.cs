using System;
using System.ComponentModel.DataAnnotations;

namespace Todorial.Data.Domain
{
    public class TodoItemListTag
    {
        [Key]
        public Guid Id { get; set; }
        public Guid TodoItemListId { get; set; }
        public Guid TagId { get; set; }

        public TodoItemList TodoItemList { get; set; }
        public Tag Tag { get; set; }
    }
}
