using News.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "INewsService" in both code and config file together.
[ServiceContract]
public interface INewsService
{
    [OperationContract]
    string GetVersion();

    // Article methods
    #region 
    [OperationContract]
    IEnumerable<ArticleDto> GetArticles();

    [OperationContract]
    ArticleDto GetArticleById(int id);

    [OperationContract]
    IEnumerable<ArticleDto> GetArticlesByPublicationDate(DateTime publishedOn);

    [OperationContract]
    IEnumerable<ArticleDto> GetArticlesByAuthor(int id);
    #endregion

    // Author methods
    #region
    [OperationContract]
    IEnumerable<AuthorDto> GetAuthors();

    [OperationContract]
    AuthorDto GetAuthorById(int id);

    [OperationContract]
    IEnumerable<AuthorDto> GetAuthorsByFirstName(string firstName);

    [OperationContract]
    IEnumerable<AuthorDto> GetAuthorsByLastName(string lastName);

    [OperationContract]
    IEnumerable<AuthorDto> GetAuthorsByFullName(string firstName, string lastName);

    [OperationContract]
    IEnumerable<AuthorDto> GetAuthorsByNewsAgency(int id);
    #endregion

    // Photo methods
    #region
    [OperationContract]
    IEnumerable<PhotoDto> GetPhotos();

    [OperationContract]
    PhotoDto GetPhotoById(int id);

    [OperationContract]
    IEnumerable<PhotoDto> GetPhotosByPublicationDate(DateTime publishedOn);

    [OperationContract]
    IEnumerable<PhotoDto> GetPhotosByAuthor(int id);
    #endregion

    // NewsAgencyMethods
    #region
    [OperationContract]
    IEnumerable<NewsAgencyDto> GetNewsAgencies();

    [OperationContract]
    NewsAgencyDto GetNewsAgencyById(int id);
    #endregion

}
