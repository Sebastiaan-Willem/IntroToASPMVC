using IntroToASPMVC.Enums;
using IntroToASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels.Contacts
{
    public class ContactDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ProfilePictureUrl { get; set; }
        public Category Category { get; set; }

        //Address uit elkaar trekken -> geen object references in ViewModel

        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string Unit { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
}
