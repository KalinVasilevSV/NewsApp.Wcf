using News.ApplicationServices.DTOs;
using News.ApplicationServices.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.ManagementServices
{
    public class ArticleManagementService : BaseManagementService
    {
        public IEnumerable<ArticleDto> GetArticles()
        {
            return _newsDBContext.Articles.Include("Topic").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").AsEnumerable().ToArticleDto();
        }

        public ArticleDto GetArticleById(int id)
        {
                return _newsDBContext.Articles.Include("Topic").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").Where(a=>a.ID==id).Single().ToArticleDto();
        }

        public IEnumerable<ArticleDto> GetArticlesByAuthor(int id)
        {
            return _newsDBContext.Articles.Include("Topic").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").Where(a => a.AuthorID==id).ToArticleDto();
        }

        public IEnumerable<ArticleDto> GetGetArticlesByPublicationDate(DateTime publishedOn)
        {
            return _newsDBContext.Articles.Include("Topic").Include("Author").Include("Author.NewsAgency").Include("Author.NewsAgency.Country").ToArticleDto().Where(a => a.PublicationDate.Date == publishedOn.Date);
        }
    }
}
