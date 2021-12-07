using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Website.Models
{
    public class PhotoVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public DateTime TakenOn { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Description { get; set; }
        public byte[] Data { get; set; }
        public string Author { get; set; }

        public PhotoVM() { }
        public PhotoVM(int id,string title,string location,string type,DateTime takenOn,DateTime publicationDate,string description, byte[] data,string authorFullName)
        {
            ID = id;
            Title = title;
            Location = location;
            Type = type;
            TakenOn = takenOn;
            PublicationDate = publicationDate;
            Description = description;
            Data = data;
            Author = authorFullName;
        }
    }
}