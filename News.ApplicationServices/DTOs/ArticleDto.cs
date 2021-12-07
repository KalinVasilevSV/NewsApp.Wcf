using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.DTOs
{
    public class ArticleDto:BaseDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public ArticleTopicDto Topic { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public AuthorDto Author { get; set; }
    }
}
