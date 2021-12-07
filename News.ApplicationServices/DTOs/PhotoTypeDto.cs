using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ApplicationServices.DTOs
{
    public class PhotoTypeDto:BaseDto
    {
        [Required]
        public string Name { get; set; }
    }
}
