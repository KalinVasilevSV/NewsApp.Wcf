using News.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Website.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly NewsServiceReference.NewsServiceClient _newsServiceClient = new NewsServiceReference.NewsServiceClient();
        // GET: Authors
        public ActionResult Index()
        {
            var authors = _newsServiceClient.GetAuthors().Select(a => new AuthorVM(a.ID,a.FirstName,a.LastName,a.Email,a.Tel,a.RegisteredOn,a.Bio,a.NewsAgency.Name));
            return View(authors);
        }
    }
}