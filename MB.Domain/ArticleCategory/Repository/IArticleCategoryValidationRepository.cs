using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategory.Repository
{
    public interface IArticleCategoryValidationRepository
    {
        bool CheckAlreadyExistTitleArticleCategory(string title);
    }
}
