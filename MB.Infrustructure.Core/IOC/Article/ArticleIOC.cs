using MB.Application.Article;
using MB.ConcreateApplication.Article.Repository;
using MB.Domain.Article.Repository;
using MB.Infrastructure.Repositories.Article;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrustructure.Core.IOC.Article
{
   public class ArticleIOC
    {
        public static void ConfigIOC(ServiceCollection services)
        {
            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            //services.AddTransient<IArticleValidationRepository, ArticleValidationRepository>();
           
        }

        
    }
}
