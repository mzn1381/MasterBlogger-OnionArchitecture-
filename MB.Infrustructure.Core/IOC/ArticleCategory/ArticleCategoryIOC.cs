using MB.Application.ArticleCategory;
using MB.ConcreateApplication.ArticleCategory.Repository;
using MB.Domain.ArticleCategory;
using MB.Domain.ArticleCategory.Repository;
using MB.Infrastructure.Context;
using MB.Infrastructure.Repositories.ArticleCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrustructure.Core.IOC.ArticleCategory
{
    public class ArticleCategoryIOC
    {
      public  static void ConfigIOC(ServiceCollection services)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryValidationRepository, ArticleCategoryValidationRepository>();
          
        }
    }
}
