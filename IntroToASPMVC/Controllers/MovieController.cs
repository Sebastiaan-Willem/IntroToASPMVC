using AutoMapper;
using IntroToASPMVC.DTOs;
using IntroToASPMVC.Models;
using IntroToASPMVC.Services;
using IntroToASPMVC.ViewModels.Movies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Controllers
{
   public class MovieController : Controller
    {
        private IMovieService _service;
        private IMapper _mapper;       
        

        public MovieController(IMovieService movieService, IMapper mapper)
        {
            _service = movieService;
            _mapper = mapper;            
        }

        //[Route("/Movies")]
        public async Task<IActionResult> Movies()
        {
            //get entities from service
            ICollection<Movie> movies = await _service.GetMoviesAsync();

            var model = new MovieViewModel
            {
                //turn entities into DTOs to present to View Layer
                Movies = _mapper.Map<ICollection<MovieDTO>>(movies)
            };

            //always pass a ViewModel to the View, never a Model/Entity
            return View(model);
        }

        //[Route("/Movie/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            var movie = await _service.GetMovieAsync(id);

            var viewModel = _mapper.Map<MovieDetailViewModel>(movie);
           
            //always pass a ViewModel to the View, never a Model/Entity
            return View(viewModel);
        }
        //[Route("/Movie/Create")]
        public IActionResult Create()
        {
            return View();
        }

        //[Route("/Movie/Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        //We pass a MovieDetailViewModel to this createmethod but best practise would be a separate ViewModel for every Action in the controller.
        //So here we "should" use a MovieCREATEViewModel, for a HTTPDELETE method we would use a MovieDELETEViewModel, etc
        //For every VIEW we have its own VIEWMODEL (even if it's identical -> separation of concerns)
        public async Task<IActionResult> Create(MovieCreateViewModel vm)
        {
            bool isValid = TryValidateModel(vm);

            if (isValid)
            {
                
                Movie movie = _mapper.Map<Movie>(vm);
                
                //save data to "database"
                await _service.AddMovieAsync(movie);                

                return RedirectToAction(nameof(Movies));
            }

            return View(vm);
           
        }

        public async Task<IActionResult> Edit(int id)
        {
            Movie movie = await _service.GetMovieAsync(id);

            if (movie == null)
            {
                return NotFound();
            }
            MovieEditViewModel vm = _mapper.Map<MovieEditViewModel>(movie);
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MovieEditViewModel vm)
        {
            bool isModelValid = TryValidateModel(vm);

            if(isModelValid)
            {
                Movie movie = _mapper.Map<Movie>(vm);
                await _service.UpdateMovieAsync(movie);


                return RedirectToAction(nameof(Movies));
            }
            return View(vm);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            Movie model = await _service.GetMovieAsync(id);
            MovieDeleteViewModel vm = _mapper.Map<MovieDeleteViewModel>(model);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(MovieDeleteViewModel vm)
        {
            if (vm == null)
            {
                return NotFound();
            }

            Movie movie = _mapper.Map<Movie>(vm);
            await _service.DeleteMovieAsync(movie);

            return RedirectToAction(nameof(Movies));
        }
    }
}
