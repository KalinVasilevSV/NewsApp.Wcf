using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Website.Models
{
    public class ArticleVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Topic { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public ArticleVM() { }
        public ArticleVM(int id, string title, string subTitle, string topic, DateTime publicationDate, string articleAbstract,string content,string authorFullName)
        {
            ID = id;
            Title = title;
            SubTitle = subTitle;
            Topic = topic;
            PublicationDate = publicationDate;
            Abstract = articleAbstract;
            Content = content;
            Author = authorFullName;
        }
    }
}