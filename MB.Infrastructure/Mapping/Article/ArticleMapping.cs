using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.Mapping.Article
{
    public class ArticleMapping : IEntityTypeConfiguration<Domain.Article.Article>
    {
        public void Configure(EntityTypeBuilder<Domain.Article.Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.ShortDescription);
            builder.Property(x => x.Image);
            builder.Property(x => x.Content);
            builder.Property(x => x.CreationDate);
            builder.Property(x => x.IsDeleted);

            builder.HasOne(c => c.ArticleCategory).WithMany(c => c.Articles).HasForeignKey(c => c.ArticleCategoryId);

        }
    }
}
