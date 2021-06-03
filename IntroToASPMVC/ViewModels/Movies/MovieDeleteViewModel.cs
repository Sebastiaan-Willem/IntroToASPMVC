using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels.Movies
{
    public class MovieDeleteViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public string ProfilePictureUrl { get; set; }
    }
}
