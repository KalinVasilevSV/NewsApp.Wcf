using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public class Author : BaseEntity
    {
        [Required, MaxLength(20)]
        public string FirstName { get; set; }
        [Required, MaxLength(20)]
        public string LastName { get; set; }
        [Required, MaxLength(20)]
        public string Email { get; set; }
        public string Tel { get; set; }
        [Required]
        public DateTime RegisteredOn { get; set; }
        public string Bio { get; set; }
        public int? NewsAgencyID { get; set; }
        public NewsAgency NewsAgency { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
