using MB.Domain.ArticleCategory;
using MB.Infrastructure.Mapping.ArticleCategory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Context
{
    public class MasterBloggerDbContext : DbContext
    {
        public DbSet<ArticleCategory>  ArticleCategories { get; set; }
        public MasterBloggerDbContext(DbContextOptions<MasterBloggerDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
