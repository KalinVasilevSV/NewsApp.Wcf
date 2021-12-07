using News.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Website.Controllers
{
    public class NewsAgenciesController : Controller
    {
        private readonly NewsServiceReference.NewsServiceClient _newsServiceClient = new NewsServiceReference.NewsServiceClient();
        // GET: NewsAgencies
        public ActionResult Index()
        {
            var newsAgencies = _newsServiceClient.GetNewsAgencies().Select(na=>new NewsAgencyVM(na.ID,na.Name,na.Address,na.Country.Name,na.Email,na.Tel,na.Description));
            return View(newsAgencies);
        }
    }
}