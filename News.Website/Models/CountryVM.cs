using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Website.Models
{
    public class CountryVM
    {
        public string Name { get; set; }

        public CountryVM() { }
        public CountryVM(string name)
        {
            Name = name;
        }
    }
}