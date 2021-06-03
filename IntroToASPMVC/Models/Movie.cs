using IntroToASPMVC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Models
{
    public class Movie: BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public Genre Genres { get; set; }
        public DateTime YearOfRelease { get; set; }
    }
}
