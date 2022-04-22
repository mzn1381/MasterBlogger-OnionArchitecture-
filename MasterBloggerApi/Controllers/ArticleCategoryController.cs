using MB.ConcreateApplication.ArticleCategory.Command;
using MB.ConcreateApplication.ArticleCategory.Dto;
using MB.ConcreateApplication.ArticleCategory.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterBloggerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleCategoryController : ControllerBase
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public ArticleCategoryController(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        [HttpGet]
        public List<ArticleCategoryQuery> GetAllArticleCategory()
        {
            return _articleCategoryApplication.List();
        }

        [HttpPost]
        public bool AddArticleCategory(ArticleCategoryCreateCommand command)
        {
            try
            {
                _articleCategoryApplication.Add(command);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        [HttpPut]
        public bool EditArticleCategory(ArticleCategoryEditCommand command)
        {
            try
            {
                _articleCategoryApplication.Edit(command);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        [HttpPut]
        public bool ActiveArticleCategory(ArticleCategoryCommandBase command)
        {
            try
            {
                _articleCategoryApplication.Active(command);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        [HttpDelete]
        public bool RemoveArticleCategory(ArticleCategoryCommandBase command)
        {
            try
            {
                _articleCategoryApplication.Remove(command);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
