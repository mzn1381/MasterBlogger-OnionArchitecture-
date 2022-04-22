using MB.Domain.ArticleCategory.Exceptions;
using MB.Domain.ArticleCategory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategory.Services
{
    public class ArticleCategoryServices : IArticleCategoryServices
    {
        private readonly IArticleCategoryValidationRepository _validationRepository;

        public ArticleCategoryServices(IArticleCategoryValidationRepository validationRepository)
        {
            _validationRepository = validationRepository;
        }

        public void CheckTitleArticleCategoryAlreadyExist(string title)
        {
            var status = _validationRepository.CheckAlreadyExistTitleArticleCategory(title);
            if (status)
                throw new DuplicatedArticleCategoryException();
        }
    }
}
