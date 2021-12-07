using News.Website.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
                //writes correct file data
                //System.IO.File.WriteAllBytes(String.Format("C:\\Users\\kalin\\source\\repos\\News\\rewrite-photos\\{0}.jpg",photo.Title), photo.Data);

                //writes incorrect file data
                //var dataString = Encoding.UTF8.GetString(photo.Data);
                //System.IO.File.WriteAllText(String.Format("C:\\Users\\kalin\\source\\repos\\News\\rewrite-photos-str\\{0}.jpg", photo.Title), dataString);

                var dataBase64 = Convert.ToBase64String(photo.Data);
                ViewData.Add(photo.ID.ToString(), dataBase64);//Convert.ToBase64String(photo.Data));
            }
            return View(photos);
        }
    }
}