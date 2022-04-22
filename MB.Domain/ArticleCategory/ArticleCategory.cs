using MB.Domain.ArticleCategory.Exceptions;
using MB.Domain.ArticleCategory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategory
{
    public class ArticleCategory
    {
        
        public long Id { get; private set; }
        
        public string Title { get; private set; }
        
        public bool IsDeleted { get; private set; }

        public DateTime CreationDate { get; private set; }

        public ArticleCategory(string title, IArticleCategoryValidationRepository validation)
        {
            GaurdAgainstNullArgumnet(title);
            validation.CheckAlreadyExistTitleArticleCategory(title);
            Title = title;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }

        public void Active()
        {
            IsDeleted = false;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void GaurdAgainstNullArgumnet(string argument)
        {
            if (string.IsNullOrWhiteSpace(argument))
            {
                throw new ArticleCategoryTitleNullException("argument can't be null ");
            }
        }

        public void Rename(string title, IArticleCategoryValidationRepository validation)
        {
            validation.CheckAlreadyExistTitleArticleCategory(title);
            GaurdAgainstNullArgumnet(title);
            Title = title;
        }


    }
}
