using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.DTOs
{
    public class PhotoDto : BaseDto
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public PhotoTypeDto Type { get; set; }
        public DateTime TakenOn { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public AuthorDto Author { get; set; }
    }
}
