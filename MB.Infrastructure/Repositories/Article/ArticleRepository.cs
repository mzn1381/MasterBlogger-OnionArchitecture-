﻿using MB.Domain.Article.Repository;
using MB.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infrastructure.Repositories.Article
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerDbContext _db;
        public ArticleRepository(MasterBloggerDbContext db)
        {
            _db = db;
        }
    }
}
