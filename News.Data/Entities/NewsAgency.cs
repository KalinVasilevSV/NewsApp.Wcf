using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public class NewsAgency : BaseEntity
    {
        [Required,MaxLength(40)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Address { get; set; }
        [Required]
        public int CountryID { get; set; }
        public Country Country { get; set; }
        [Required, MaxLength(40)]
        public string Email { get; set; }
        public string Tel { get; set; }
        [Required, MaxLength(2000)]
        public string Description { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
