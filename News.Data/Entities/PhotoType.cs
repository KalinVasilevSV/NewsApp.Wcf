using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Entities
{
    public class PhotoType:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
