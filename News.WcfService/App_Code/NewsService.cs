using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using News.ApplicationServices.DTOs;
using News.ApplicationServices.ManagementServices;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NewsService" in code, svc and config file together.
public class NewsService : INewsService
{
    private readonly ArticleManagementService _articleService = new ArticleManagementService();
    private readonly AuthorManagementService _authorService = new AuthorManagementService();
    private readonly PhotoManagementService _photoService = new PhotoManagementService();
    private readonly NewsAgencyManagementService _newsAgencyService =new NewsAgencyManagementService();

    public string GetVersion()
    {
        return "News Service Version 1.0";
    }

    // Articles methods
    #region
    public IEnumerable<ArticleDto> GetArticles()
    {
        return _articleService.GetArticles();
    }

    public ArticleDto GetArticleById(int id)
    {
        return _articleService.GetArticleById(id);
    }

    public IEnumerable<ArticleDto> GetArticlesByAuthor(int id)
    {
        return _articleService.GetArticlesByAuthor(id);
    }

    public IEnumerable<ArticleDto> GetArticlesByPublicationDate(DateTime publishedOn)
    {
        return _articleService.GetGetArticlesByPublicationDate(publishedOn);
    }
    #endregion

    // Author methods
    #region
    public IEnumerable<AuthorDto> GetAuthors()
    {
        return _authorService.GetAuthors();
    }
    public AuthorDto GetAuthorById(int id)
    {
        return _authorService.GetAuthorById(id);
    }

    public IEnumerable<AuthorDto> GetAuthorsByFirstName(string firstName)
    {
        return _authorService.GetAuthorsByFirstName(firstName);
    }
    public IEnumerable<AuthorDto> GetAuthorsByLastName(string lastName)
    {
        return _authorService.GetAuthorsByLastName(lastName);
    }
    public IEnumerable<AuthorDto> GetAuthorsByFullName(string firstName, string lastName)
    {
        return _authorService.GetAuthorsByFullName(firstName,lastName);
    }
        public IEnumerable<AuthorDto> GetAuthorsByNewsAgency(int id)
    {
        return _authorService.GetAuthorsByNewsAgency(id);
    }
    #endregion

    // Photo methods
    #region
    public IEnumerable<PhotoDto> GetPhotos()
    {
        return _photoService.GetPhotos();
    }
    public PhotoDto GetPhotoById(int id)
    {
        return _photoService.GetPhotoById(id);
    }

    public IEnumerable<PhotoDto> GetPhotosByAuthor(int id)
    {
        return _photoService.GetPhotosByAuthor(id);
    }

    public IEnumerable<PhotoDto> GetPhotosByPublicationDate(DateTime publishedOn)
    {
        return _photoService.GetPhotosByPublicationDate(publishedOn);
    }
    #endregion

    //  News Agency methods
    #region
    public IEnumerable<NewsAgencyDto> GetNewsAgencies()
    {
        return _newsAgencyService.GetNewsAgencies();
    }

    public NewsAgencyDto GetNewsAgencyById(int id)
    {
        return _newsAgencyService.GetNewsAgencyById(id);
    }
    #endregion
}
