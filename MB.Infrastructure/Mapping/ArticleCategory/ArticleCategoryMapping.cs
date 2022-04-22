using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB.Domain.ArticleCategory;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.Mapping.ArticleCategory
{
    public class ArticleCategoryMapping : IEntityTypeConfiguration<Domain.ArticleCategory.ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<Domain.ArticleCategory.ArticleCategory> builder)
        {
            builder.ToTable("ArticleCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.CreationDate);
        }
    }
}
