using System;
using Todorial.Data.Domain.Abstract;

namespace Todorial.Data.Domain
{
    public class Tag : Entity<Guid>
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }
    }
}
