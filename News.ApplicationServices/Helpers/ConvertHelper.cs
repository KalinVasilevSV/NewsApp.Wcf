using News.ApplicationServices.DTOs;
using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.Helpers
{
    public static class ConvertHelper
    {
        // Article helpers
        #region
        public static Article ToArticleEntity(this ArticleDto articleDto)
        {
            return new Article
            {
                ID = articleDto.ID,
                Title = articleDto.Title,
                SubTitle = articleDto.SubTitle,
                Topic = articleDto.Topic.ToArticleTopicEntity(),
                PublicationDate = articleDto.PublicationDate,
                Abstract = articleDto.Abstract,
                Content = articleDto.Content,
                Author = articleDto.Author.ToAuthorEntity()
            };
        }
        public static ArticleDto ToArticleDto(this Article article)
        {
            return new ArticleDto
            {
                ID=article.ID,
                Title = article.Title,
                SubTitle = article.SubTitle,
                Topic = article.Topic.ToArticleTopicDto(),
                PublicationDate = article.PublicationDate,
                Abstract = article.Abstract,
                Content=article.Content,
                Author = article.Author.ToAuthorDto()
            };
        }
        public static IEnumerable<ArticleDto> ToArticleDto(this IEnumerable<Article> articles)
        {
            return articles.Select(x => x.ToArticleDto());
        }

        public static ArticleTopic ToArticleTopicEntity(this ArticleTopicDto articleTopicDto)
        {
            return new ArticleTopic { ID = articleTopicDto.ID, Name = articleTopicDto.Name };
        }

        public static ArticleTopicDto ToArticleTopicDto(this ArticleTopic articleTopic)
        {
            return new ArticleTopicDto { ID = articleTopic.ID, Name = articleTopic.Name };
        }
        #endregion

        // Author helpers
        #region
        public static Author ToAuthorEntity(this AuthorDto authorDto)
        {
            return new Author
            {
                ID = authorDto.ID,
                FirstName = authorDto.FirstName,
                LastName = authorDto.LastName,
                Email = authorDto.Email,
                Tel = authorDto.Tel,
                RegisteredOn = authorDto.RegisteredOn,
                Bio = authorDto.Bio,
                NewsAgency = authorDto.NewsAgency.ToNewsAgencyEntity()
            };
        }
        public static AuthorDto ToAuthorDto(this Author author)
        {
            return new AuthorDto
            {
                ID = author.ID,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Tel = author.Tel,
                RegisteredOn = author.RegisteredOn,
                Bio = author.Bio,
                NewsAgency = author.NewsAgency.ToNewsAgencyDto()
            };
        }

        public static IEnumerable<AuthorDto> ToAuthorDto(this IEnumerable<Author> authors)
        {
            return authors.Select(x => x.ToAuthorDto());
        }
        #endregion

        // Photo helpers
        #region
        public static Photo ToPhotoEntity(this PhotoDto photoDto)
        {
            return new Photo
            {
                ID = photoDto.ID,
                Title = photoDto.Title,
                Location = photoDto.Location,
                Type=photoDto.Type.ToPhotoTypeEntity(),
                TakenOn = photoDto.TakenOn,
                PublicationDate = photoDto.PublicationDate,
                Description = photoDto.Description,
                Data = photoDto.Data,
                Author = photoDto.Author.ToAuthorEntity()
            };
        }
        public static PhotoDto ToPhotoDto(this Photo photo)
        {
            return new PhotoDto
            {
                ID = photo.ID,
                Title = photo.Title,
                Location = photo.Location,
                Type=photo.Type.ToPhotoTypeDto(),
                TakenOn = photo.TakenOn,
                PublicationDate = photo.PublicationDate,
                Description = photo.Description,
                Data = photo.Data,
                Author = photo.Author.ToAuthorDto()
            };
        }

        public static IEnumerable<PhotoDto> ToPhotoDto(this IEnumerable<Photo> photos)
        {
            return photos.Select(x => x.ToPhotoDto());
        }

        public static PhotoType ToPhotoTypeEntity(this PhotoTypeDto photoTypeDto)
        {
            return new PhotoType { ID = photoTypeDto.ID, Name = photoTypeDto.Name };
        }

        public static PhotoTypeDto ToPhotoTypeDto(this PhotoType photoType)
        {
            return new PhotoTypeDto { ID = photoType.ID, Name = photoType.Name };
        }
        #endregion

        // NewsAgency helpers
        #region
        public static NewsAgency ToNewsAgencyEntity(this NewsAgencyDto newsAgencyDto)
        {
            return new NewsAgency
            {
                ID = newsAgencyDto.ID,
                Name = newsAgencyDto.Name,
                Address = newsAgencyDto.Address,
                Country = newsAgencyDto.Country.ToCountryEntity(),
                Email = newsAgencyDto.Email,
                Tel = newsAgencyDto.Tel,
                Description = newsAgencyDto.Description
            };
        }
        public static NewsAgencyDto ToNewsAgencyDto(this NewsAgency newsAgency)
        {
            return new NewsAgencyDto
            {
                ID = newsAgency.ID,
                Name = newsAgency.Name,
                Address = newsAgency.Address,
                Country = newsAgency.Country.ToCountryDto(),
                Email = newsAgency.Email,
                Tel = newsAgency.Tel,
                Description = newsAgency.Description
            };
        }
        public static IEnumerable<NewsAgencyDto> ToNewsAgencyDto(this IEnumerable<NewsAgency> newsAgencies)
        {
            return newsAgencies.Select(x => x.ToNewsAgencyDto());
        }
        public static Country ToCountryEntity(this CountryDto countryDto)
        {
            return new Country { ID = countryDto.ID, Name = countryDto.Name };
        }

        public static CountryDto ToCountryDto(this Country country)
        {
            return new CountryDto { ID = country.ID, Name = country.Name };
        }
        #endregion
    }
}
