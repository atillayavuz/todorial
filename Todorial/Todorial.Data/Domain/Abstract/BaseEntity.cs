using System;
using System.ComponentModel.DataAnnotations;

namespace Todorial.Data.Domain.Abstract
{
    public abstract class BaseEntity<T> where T : struct
    {
        [Key]
        public T Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
