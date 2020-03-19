using System;
using System.Collections.Generic;
using System.Text;

namespace ContentManagement.Infrastructure.Base
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? EditedTime { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
