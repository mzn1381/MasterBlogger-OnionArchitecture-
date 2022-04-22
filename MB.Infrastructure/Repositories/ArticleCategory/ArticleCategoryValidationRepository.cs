using MB.Domain.ArticleCategory.Repository;
using MB.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Repositories.ArticleCategory
{
    public class ArticleCategoryValidationRepository : IArticleCategoryValidationRepository
    {
        private readonly MasterBloggerDbContext _db;
        public ArticleCategoryValidationRepository(MasterBloggerDbContext db)
        {
            _db = db;
        }
        public bool CheckAlreadyExistTitleArticleCategory(string title)
        {
            return _db.ArticleCategories.Any(c => c.Title.ToLower().Trim() == title.ToLower().Trim());
        }
    }
}
