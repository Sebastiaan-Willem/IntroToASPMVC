using IntroToASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels.Contacts
{
    public class ContactDeleteViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}
