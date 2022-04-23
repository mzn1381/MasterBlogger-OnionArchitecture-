using MB.ConcreateApplication.Article.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.ConcreateApplication.Article.Repository
{
    public interface IArticleApplication : IArticleApplicationBase
    {
        List<ArticleListQuery> GetList();
    }
}
