﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.ConcreateApplication.ArticleCategory.Command
{
  public  class ArticleCategoryCreateCommand:ArticleCategoryCommandBase
    {
        public string Title { get; set; }
    }
}
