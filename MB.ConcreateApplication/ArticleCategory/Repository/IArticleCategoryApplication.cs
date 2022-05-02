using MB.ConcreateApplication.ArticleCategory.Command;
using MB.ConcreateApplication.ArticleCategory.Dto;
using MB.ConcreateApplication.ArticleCategory.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.ConcreateApplication.ArticleCategory.Repository
{
    public interface IArticleCategoryApplication : IArticleCategoryRepositoryBase
    {
        List<ArticleCategoryQuery> List();
        void Add(ArticleCategoryCreateCommand command);
        void Edit(ArticleCategoryEditCommand command);
        void Remove(ArticleCategoryCommandBase command);
        void Active(ArticleCategoryCommandBase command);
        List<ArticleCategorySelectListQuery> ArticleCategorySelectListQueries();
    }
}
