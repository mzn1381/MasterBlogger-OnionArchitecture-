using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategory.Repository
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategory articleCategory);
        List<ArticleCategory> GetAll();
        ArticleCategory GetBy(long Id);
        void Edit(long Id,string Title);
        void Active(long Id);
        void Remove(long Id);
        void Save();
    }
}
