using MB.ConcreateApplication.Article.Query;
using MB.ConcreateApplication.Article.Repository;
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
    public class ArticleController : ControllerBase
    {
        private readonly IArticleApplication _articleApplication;
        public ArticleController(IArticleApplication articleApplication)
        {
            _articleApplication = articleApplication;
        }
        [HttpGet]
        public List<ArticleListQuery> GetArticleList() 
        {
            try
            {
                return _articleApplication.GetList();
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
    }
}
