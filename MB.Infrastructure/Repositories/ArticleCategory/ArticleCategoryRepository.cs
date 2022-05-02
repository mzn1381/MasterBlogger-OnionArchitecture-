
using MB.ConcreateApplication.ArticleCategory.Query;
using MB.Domain.ArticleCategory.Repository;
using MB.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace MB.Infrastructure.Repositories.ArticleCategory
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBloggerDbContext _dbContext;
        private readonly IArticleCategoryValidationRepository _validation;

        public ArticleCategoryRepository(MasterBloggerDbContext dbContext,IArticleCategoryValidationRepository validation)
        {
            _validation = validation;
            _dbContext = dbContext;
        }

        public void Create(Domain.ArticleCategory.ArticleCategory articleCategory)
        {
            _dbContext.Add(articleCategory);
            Save();
        }

        public List<Domain.ArticleCategory.ArticleCategory> GetAll()
        {
            return _dbContext.ArticleCategories.ToList();
        }

        public Domain.ArticleCategory.ArticleCategory GetBy(long Id)
        {
            return _dbContext.ArticleCategories.FirstOrDefault(c => c.Id == Id);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Edit(long Id, string Title)
        {
            var articleCategory = GetBy(Id);
            articleCategory.Rename(Title,_validation);
            Save();
        }

        public void Active(long Id)
        {
            var article = GetBy(Id);
            article.Active();
            Save();
        }

        public void Remove(long Id)
        {
            var article = GetBy(Id);
            article.Remove();
            Save();
        }

        public List<ArticleCategorySelectListQuery> ArticleCategorySelectLists()
        {
            return _dbContext.ArticleCategories.Select(x => new ArticleCategorySelectListQuery()
            {
                Id=x.Id,
                Name=x.Title
            }).ToList();
        }
    }
}
