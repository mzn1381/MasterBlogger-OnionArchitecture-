using MB.ConcreateApplication.Article.Query;
using MB.Domain.Article.Repository;
using MB.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Repositories.Article
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerDbContext _db;

        public ArticleRepository(MasterBloggerDbContext db)
        {
            _db = db;
        }

        public void Create(Domain.Article.Article article)
        {
            _db.Add(article);
            _db.SaveChanges();
        }

        public List<ArticleListQuery> GetList()
        {
            return _db.Articles.Select(c => new ArticleListQuery()
            {
                Id = c.Id,
                ArticleCategory = c.ArticleCategory.Title,
                Title = c.Title,
                CreationDate = c.CreationDate.ToString(CultureInfo.InvariantCulture),
                IsDeleted = c.IsDeleted
            }).ToList();
        }
    }
}
