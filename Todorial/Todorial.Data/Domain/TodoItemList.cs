﻿using System;
using System.Collections.Generic;
using Todorial.Data.Domain.Abstract;

namespace Todorial.Data.Domain
{
    public class TodoItemList : BaseDomainEntity<Guid>
    {
        public string Name { get; set; }

        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
