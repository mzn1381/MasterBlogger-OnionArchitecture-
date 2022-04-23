using MB.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.Article
{
    public class Article : BaseDomain
    {
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Image { get; private set; }
        public string Content { get; private set; }
        public long ArticleCategoryId { get; private set; }
        public MB.Domain.ArticleCategory.ArticleCategory ArticleCategory { get; private set; }
        protected Article()
        {

        }

        public Article(string title, string shortDescription, string image, string context, long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = context;
            ArticleCategoryId = articleCategoryId;
            CreationDate = DateTime.Now;
            IsDeleted = false;
        }
    }
}
