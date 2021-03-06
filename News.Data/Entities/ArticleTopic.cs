using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public class ArticleTopic:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
