using ContentManagement.DataAccess.ContentRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagement.DataAccess.Wrapper
{
    public interface IWrapper
    {
        IContentRepository ContentRepository { get; set; }


    }
}
