using IntroToASPMVC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels.Contacts
{
    public class ContactViewModel
    {
        public ICollection<ContactDTO> Contacts { get; set; }
    }
}
