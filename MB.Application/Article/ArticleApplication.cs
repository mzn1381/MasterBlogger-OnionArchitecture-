using MB.ConcreateApplication.Article.Query;
using MB.ConcreateApplication.Article.Repository;
using MB.Domain.Article.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Article
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public List<ArticleListQuery> GetList()
        {
            return _articleRepository.GetList();
        }
    }
}
