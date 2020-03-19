using ContentManagement.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentManagement.Domain.Entities
{
    public class Content : BaseEntity<int>
    {
        public string Subject { get; set; }
        public string Text{ get; set; }
        public string Author { get; set; }
        public string Link { get; set; }
    }
}
