using IntroToASPMVC.Enums;
using IntroToASPMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels.Contacts
{
    public class ContactCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]      
        public int TelephoneNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [DisplayName("Profile Picture URL")]
        public string ProfilePictureUrl { get; set; }

        [Required]
        public Category Category { get; set; }
        //Address uit elkaar trekken -> geen object references in ViewModel

        [Required]
        public string Street { get; set; }

        [Required]
        public int HouseNumber { get; set; }
        public string Unit { get; set; }

        [Required]
        public int PostalCode { get; set; }

        [Required]
        [MaxLength(30)]
        public string City { get; set; }
    }
}
