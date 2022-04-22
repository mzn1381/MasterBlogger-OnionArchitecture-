
using System;

namespace MB.Domain.ArticleCategory.Exceptions
{
    public class ArticleCategoryTitleNullException : Exception
    {
        public ArticleCategoryTitleNullException()
        {

        }
        public ArticleCategoryTitleNullException(string message) : base(message)
        {

        }
    }
}
