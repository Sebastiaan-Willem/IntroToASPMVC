using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels
{
    public class CursistViewModel
    {
        public int Id { get; set; }

        //Authentication data annotations (further handled in controller and view)
        
        [DisplayName("Voornaam")] //custom displayname
        [Required(ErrorMessage = "Voornaam is verplicht")] //custom error messages: 
        [MinLength(3, ErrorMessage = "Tenminste 3 karakters")]
        [MaxLength(20, ErrorMessage = "Maximaal 20 karakters")]
        public string FirstName { get; set; }

        //custom displayname
        [DisplayName("Achternaam")]
        [Required]
        public string Name { get; set; }

        public ICollection<string> Courses { get; set; }

        
        [Range(12,18)] //based on doubles                 
        public int Age { get; set; }

        public int Gender { get; set; }


        //[Range(typeof(DateTime), "01/01/1970", "01/01/2003")]  
        //This can also be used to authenticate datetime values between a certain range
    }
}
