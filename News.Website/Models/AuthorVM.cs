using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Website.Models
{
    public class AuthorVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string Bio { get; set; }
        public string NewsAgency { get; set; }

        public AuthorVM() { }
        public AuthorVM(int id,string firstName,string lastName,string email,string tel,DateTime registeredOn,string bio,string newsAgencyName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Tel = tel;
            RegisteredOn = registeredOn;
            Bio = bio;
            NewsAgency = newsAgencyName;
        }
    }
}