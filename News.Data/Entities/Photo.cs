using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public class Photo:BaseEntity
    {
        [Required, MaxLength(60)]
        public string Title { get; set; }
        public string Location { get; set; }
        [Required]
        public int PhotoTypeID { get; set; }
        public PhotoType Type { get; set; }
        public DateTime TakenOn { get; set; }
        [Required]
        public DateTime PublicationDate { get; set; }
        [Required, MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public byte[] Data { get; set; }
        [Required]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
    }
}
