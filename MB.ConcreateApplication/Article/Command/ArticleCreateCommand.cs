using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.ConcreateApplication.Article.Command
{
   public class ArticleCreateCommand:ArticleCommandBase
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Content{ get; set; }
        public long ArticleCategoryId{ get; set; }
    }
}
