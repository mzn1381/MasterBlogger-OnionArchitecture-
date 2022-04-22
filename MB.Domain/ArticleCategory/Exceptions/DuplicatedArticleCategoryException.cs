using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategory.Exceptions
{
    public class DuplicatedArticleCategoryException : Exception
    {
        public DuplicatedArticleCategoryException()
        {

        }
        public DuplicatedArticleCategoryException(string meesge) : base(meesge)
        {

        }
    }
}
