using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.DTOs
{
    public class AuthorDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string Bio { get; set; }
        public NewsAgencyDto NewsAgency { get; set; }
    }
}
