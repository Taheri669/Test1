using ContentManagement.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagement.DataAccess.ContentRepository
{
    public interface IContentRepository
    {
        Task<List<ContentViewModel>> GetAll();
        Task<ContentViewModel> GetById(int id);
        Task<int> Add(ContentViewModel model);
        Task<bool> Update(ContentViewModel model);
        Task<bool> Delete(int id);

    }
}
