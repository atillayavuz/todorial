using System.Data.Entity;
using Todorial.Data.Domain;

namespace Todorial.Data.Context
{
    public class TodorialContext : DbContext
    {
        #region "Constructors"

        public TodorialContext()
            : base("name=DefaultConnection")
        {

        }

        #endregion

        #region "Todo Items & Lists"

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoItemList> TodoItemLists { get; set; }
        
        #endregion

        #region "Tags"

        public DbSet<Tag> Tags { get; set; }

        #endregion

        #region "TodoItemLists & Tags"

        public DbSet<TodoItemListTag> TodoItemListTags { get; set; }

        #endregion
    }
}