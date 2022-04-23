using MB.Infrustructure.Core.IOC.Article;
using MB.Infrustructure.Core.IOC.ArticleCategory;
using MB.Infrustructure.Core.IOC.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MasterBloggerApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region ConfigArticleCategoryIOC 
            ArticleCategoryIOC.ConfigIOC((ServiceCollection)services);
            #endregion

            #region ConfigArticleIOC
            ArticleIOC.ConfigIOC((ServiceCollection)services);
            #endregion

            #region ConfigContext
            ContextIOC.ConfigIOC((ServiceCollection)services,Configuration.GetConnectionString("MBBank"));
            #endregion

            #region AnotherConfig
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MasterBloggerApi", Version = "v1" });
            });
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MasterBloggerApi v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
