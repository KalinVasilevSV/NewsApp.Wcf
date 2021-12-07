using News.ApplicationServices.DTOs;
using News.ApplicationServices.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.ManagementServices
{
    public class NewsAgencyManagementService : BaseManagementService
    {
        public IEnumerable<NewsAgencyDto> GetNewsAgencies()
        {
            return _newsDBContext.NewsAgencies.Include("Country").AsNoTracking().AsEnumerable().ToNewsAgencyDto();
        }

        public NewsAgencyDto GetNewsAgencyById(int id)
        {
            return _newsDBContext.NewsAgencies.Include("Country").Where(n => n.ID == id).Single().ToNewsAgencyDto();
        }
    }
}
