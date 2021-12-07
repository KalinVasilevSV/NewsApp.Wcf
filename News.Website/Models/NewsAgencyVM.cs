using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Website.Models
{
    public class NewsAgencyVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Description { get; set; }

        public NewsAgencyVM() { }

        public NewsAgencyVM(int id,string name,string address,string countryName,string email,string tel, string description)
        {
            ID = id;
            Name = name;
            Address = address;
            Country = countryName;
            Email = email;
            Tel = tel;
            Description = description;
        }
    }
}