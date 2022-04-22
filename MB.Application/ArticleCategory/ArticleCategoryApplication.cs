using MB.ConcreateApplication.ArticleCategory.Command;
using MB.ConcreateApplication.ArticleCategory.Dto;
using MB.ConcreateApplication.ArticleCategory.Repository;
using MB.Domain.ArticleCategory;
using MB.Domain.ArticleCategory.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.ArticleCategory
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IArticleCategoryValidationRepository _validation;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidationRepository validation)
        {
            _validation = validation;
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void Active(ArticleCategoryCommandBase command)
        {
            _articleCategoryRepository.Active(command.Id);
        }

        public void Add(ArticleCategoryCreateCommand command)
        {
            var articleCategory = new Domain.ArticleCategory.ArticleCategory(command.Title, _validation);
            _articleCategoryRepository.Create(articleCategory);
        }

        public void Edit(ArticleCategoryEditCommand command)
        {
            _articleCategoryRepository.Edit(command.Id, command.Title);
        }

        public List<ArticleCategoryQuery> List()
        {
            var result = _articleCategoryRepository.GetAll();
            var model = new List<ArticleCategoryQuery>();
            foreach (var item in result)
            {
                model.Add(new ArticleCategoryQuery()
                {
                    CreationDate = item.CreationDate.ToString(CultureInfo.InvariantCulture)
                    ,
                    Id = item.Id,
                    IsDeleted = item.IsDeleted,
                    Title = item.Title
                });
            }
            return model;
        }

        public void Remove(ArticleCategoryCommandBase command)
        {
            _articleCategoryRepository.Remove(command.Id);
        }
    }
}
