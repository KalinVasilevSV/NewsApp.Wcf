using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Data.Context
{
    public class NewsDBContext:DbContext
    {
        public DbSet<NewsAgency> NewsAgencies { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
