using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContentManagement.Domain.ViewModels;
using System.Linq;
using ContentManagement.Domain.Data;
using ContentManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContentManagement.DataAccess.ContentRepository
{
    public class ContentRepository : IContentRepository
    {
        public readonly ApplicationDbContext _context;
        public ContentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ContentViewModel> GetById(int id)
        {        
            var content = await _context.Contents.Where(p => p.Id == id).Select(p => new ContentViewModel()
            {
                Id=p.Id,
                CreatedTime = p.CreatedTime,
                Author = p.Author,
                Link = p.Link,
                Subject = p.Subject,
                TextBody = p.Text
            }).SingleOrDefaultAsync();
            return content;
        }


        public async Task<List<ContentViewModel>> GetAll()
        {
            var contents = await _context.Contents.Select(p => new ContentViewModel()
            {
                Id=p.Id,
                CreatedTime = p.CreatedTime,
                Author = p.Author,
                Link = p.Link,
                Subject = p.Subject,
                TextBody = p.Text
            }).OrderByDescending(p => p.CreatedTime)
              .ToListAsync();
            return contents;
        }


        public async Task<int> Add(ContentViewModel model)
        {
            var content = new Content()
            {
                Author = model.Author,
                Subject = model.Subject,
                Link = model.Link,
                Text = model.TextBody,
                CreatedTime = DateTime.Now,
            };
            await _context.Contents.AddAsync(content);
            await _context.SaveChangesAsync();
            return content.Id;
        }


        public async Task<bool> Update(ContentViewModel model)
        {
            var content = await IsExist(model.Id.Value);
            if (content != null)
            {
                 content = new Content()
                {
                    Author = model.Author,
                    Subject = model.Subject,
                    Link = model.Link,
                     Text = model.TextBody,
                    CreatedTime = model.CreatedTime,
                    EditedTime = DateTime.Now
                };
                _context.Contents.Update(content);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }


        public async Task<bool> Delete(int id)
        {
            var content=await IsExist(id);
            if (content != null)
            {
                content.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Content> IsExist(int id)
        {
            var content = await _context.Contents.SingleOrDefaultAsync(p => p.Id == id);
            return content;
        }
    }
}
