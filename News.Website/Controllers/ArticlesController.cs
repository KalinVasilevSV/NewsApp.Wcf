using News.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Website.Controllers
{
    public class ArticlesController : Controller
    {

        private readonly NewsServiceReference.NewsServiceClient _newsServiceClient = new NewsServiceReference.NewsServiceClient();
        // GET: Articles
        public ActionResult Index()
        {
            var articles = _newsServiceClient.GetArticles().Select(a => new ArticleVM(a.ID,a.Title,a.SubTitle,a.Topic.Name,a.PublicationDate,a.Abstract,a.Content,String.Join(" ",new string[] { a.Author.FirstName,a.Author.LastName})));
            return View(articles);
        }
    }
}