using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.DTOs
{
    public class NewsAgencyDto : BaseDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public CountryDto Country { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Description { get; set; }
    }
}
