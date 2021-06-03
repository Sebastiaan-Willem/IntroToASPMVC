using IntroToASPMVC.DTOs;
using IntroToASPMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.ViewModels.Movies
{
    public class MovieViewModel
    {
       public ICollection<MovieDTO> Movies { get; set; } 
    }
}
