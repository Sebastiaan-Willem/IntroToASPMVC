using IntroToASPMVC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels.Movies
{
    public class MovieEditViewModel
    {
        public int Id { get; set; }

        [DisplayName("Titel")]
        [Required]
        public string Title { get; set; }

        [DisplayName("Korte Beschrijving")]
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [DisplayName("Score op 10")]
        [Range(1, 10)]
        public int Rating { get; set; }

        [DisplayName("Datum waarop de film uit kwam.")]
        [Range(typeof(DateTime), "01-01-1970", "01-01-2100", ErrorMessage = "Film moet van minstens 1970 zijn.")]
        public DateTime? YearOfRelease { get; set; }
    }
}
