using News.ApplicationServices.DTOs;
using News.ApplicationServices.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.ManagementServices
{
    public class PhotoManagementService : BaseManagementService
    {
        public IEnumerable<PhotoDto> GetPhotos()
        {
            return _newsDBContext.Photos.Include("Type").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").AsEnumerable().ToPhotoDto();
        }

        public PhotoDto GetPhotoById(int id)
        {
            return _newsDBContext.Photos.Include("Type").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").Where(p => p.ID == id).Single().ToPhotoDto();
        }

        public IEnumerable<PhotoDto> GetPhotosByAuthor(int id)
        {
            return _newsDBContext.Photos.Include("Type").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").Where(p => p.AuthorID == id).ToPhotoDto();
        }

        public IEnumerable<PhotoDto> GetPhotosByPublicationDate(DateTime publishedOn)
        {
            return _newsDBContext.Photos.Include("Type").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").ToPhotoDto().Where(p => p.PublicationDate.Date == publishedOn.Date);
        }
    }
}
