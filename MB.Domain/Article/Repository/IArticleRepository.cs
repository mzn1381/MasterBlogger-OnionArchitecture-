using MB.ConcreateApplication.Article.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Article.Repository
{
   public interface IArticleRepository
    {
        List<ArticleListQuery> GetList();
    }
}
