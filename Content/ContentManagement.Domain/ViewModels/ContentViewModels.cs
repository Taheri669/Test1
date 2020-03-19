using System;
using System.Collections.Generic;
using System.Text;

namespace ContentManagement.Domain.ViewModels
{
    public class ContentViewModel
    {
        public int? Id{ get; set; }
        public DateTime? CreatedTime { get; set; }
        public string Subject { get; set; }
        public string TextBody { get; set; }
        public string Author { get; set; }
        public string Link { get; set; }
    }
}
