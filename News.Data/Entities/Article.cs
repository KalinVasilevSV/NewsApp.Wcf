using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public class Article:BaseEntity
    {
        [Required, MaxLength(60)]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        [Required]
        public int ArticleTopicID { get; set; }
        public ArticleTopic Topic { get; set; }
        [Required]
        public DateTime PublicationDate { get; set; }
        [Required, MaxLength(2000)]
        public string Abstract { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
