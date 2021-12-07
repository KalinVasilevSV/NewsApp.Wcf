using News.ApplicationServices.DTOs;
using News.ApplicationServices.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.ManagementServices
{
    public class AuthorManagementService:BaseManagementService
    {
        public IEnumerable<AuthorDto> GetAuthors()
        {
            return _newsDBContext.Authors.Include("NewsAgency").Include("NewsAgency.Country").AsNoTracking().AsEnumerable().ToAuthorDto();
        }

        public AuthorDto GetAuthorById(int id)
        {
            return _newsDBContext.Authors.Include("NewsAgency").Include("NewsAgency.Country").Where(a => a.ID == id).Single().ToAuthorDto();
        }

        public IEnumerable<AuthorDto> GetAuthorsByFirstName(string firstName)
        {
            return _newsDBContext.Authors.Include("NewsAgency").Include("NewsAgency.Country").Where(a => a.FirstName == firstName).ToAuthorDto();
        }

        public IEnumerable<AuthorDto> GetAuthorsByLastName(string lastName)
        {
            return _newsDBContext.Authors.Include("NewsAgency").Include("NewsAgency.Country").Where(a => a.LastName == lastName).ToAuthorDto();
        }

        public IEnumerable<AuthorDto> GetAuthorsByFullName(string firstName, string lastName)
        {
            return _newsDBContext.Authors.Include("NewsAgency").Include("NewsAgency.Country").Where(a => a.FirstName == firstName && a.LastName == lastName).ToAuthorDto();
        }

        public IEnumerable<AuthorDto> GetAuthorsByNewsAgency(int id)
        {
            return _newsDBContext.Authors.Include("NewsAgency").Include("NewsAgency.Country").Where(a => a.NewsAgencyID == id).ToAuthorDto();
        }
    }
}
