using IntroToASPMVC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }

        //string[] instead of enum[] since we only need to know the value for display purposes in a DTO
        public string Genre { get; set; }
        public DateTime YearOfRelease { get; set; }
    }
}
