using MB.ConcreateApplication.ArticleCategory.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.ConcreateApplication.ArticleCategory.Dto
{
   public class ArticleCategoryQuery:ArticleCategoryQueryBase
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
