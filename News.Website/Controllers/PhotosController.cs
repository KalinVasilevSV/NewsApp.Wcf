using News.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Website.Controllers
{
    public class PhotosController : Controller
    {
        private readonly NewsServiceReference.NewsServiceClient _newsServiceClient = new NewsServiceReference.NewsServiceClient();
        // GET: Photos
        public ActionResult Index()
        {
            var photos = _newsServiceClient.GetPhotos().Select(p => new PhotoVM(p.ID,p.Title,p.Location,p.Type.Name,p.TakenOn,p.PublicationDate,p.Description,p.Data,String.Join(" ",new string[] { p.Author.FirstName,p.Author.LastName})));
            foreach(PhotoVM photo in photos)
            {
                ViewData.Add(photo.ID.ToString(), Convert.ToBase64String(photo.Data));
            }
            return View(photos);
        }
    }
}