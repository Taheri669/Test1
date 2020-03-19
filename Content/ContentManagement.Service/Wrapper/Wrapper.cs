using ContentManagement.DataAccess.ContentRepository;
using ContentManagement.DataAccess.Wrapper;
using ContentManagement.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Content_Repository = ContentManagement.DataAccess.ContentRepository.ContentRepository;

namespace ContentManagement.DataAccess.Wrapper
{
    public class Wrapper:IWrapper
    {
        public readonly ApplicationDbContext _context;
        public Wrapper(ApplicationDbContext context)
        {
            _context = context;
            ContentRepository = new Content_Repository(_context);
        }
        public IContentRepository ContentRepository { get; set; }


    }
}
