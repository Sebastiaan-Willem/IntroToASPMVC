using IntroToASPMVC.Enums;
using IntroToASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.DTOs
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }
        public string ProfilePictureUrl { get; set; }
        public Category Category { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
    }
}
