﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleCategory.Services
{
    public interface IArticleCategoryServices
    {
        void CheckTitleArticleCategoryAlreadyExist(string title);
    }
}
