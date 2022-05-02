using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.ConcreateApplication.ArticleCategory.Query
{
    public class ArticleCategorySelectListQuery : ArticleCategoryQueryBase
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
