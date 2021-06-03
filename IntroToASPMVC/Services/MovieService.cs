using IntroToASPMVC.Data;
using IntroToASPMVC.Enums;
using IntroToASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Services
{
    public class MovieService : IMovieService
    {

        /* WITHOUT DATABASE: 
         * 
         *  In StartUp.cs -> services.AddSingleton<IMovieService, MovieService>();
         *  to turn this into a singleton class
         * 
         * */

        //private List<Movie> movies;

        private IGenericRepo<Movie> _repo;

        public MovieService(IGenericRepo<Movie> repo)
        {
            //SeedData();
            _repo = repo;
        }
        public async Task<ICollection<Movie>> GetMoviesAsync()
        {
            //return movies;
            return await _repo.GetEntitiesAsync();
        }

        public async Task<Movie> GetMovieAsync(int id)
        {
            //return movies.SingleOrDefault(x => x.Id == id);
            return await _repo.GetEntityAsync(id);
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            //TODO
            await _repo.UpdateEntityAsync(movie);
        }

        public async Task AddMovieAsync(Movie movie)
        {
            //movies.Add(movie);
            await _repo.AddEntityAsync(movie);
        }

        public async Task DeleteMovieAsync(Movie movie)
        {
            //movies.Remove(movie);
            await _repo.DeleteEntityAsync(movie);
        }

        //public void SeedData()
        //{
        //    //WITHOUT DATABASE
        //    var movies = new List<Movie>
        //    {
        //        new Movie
        //        {
        //            Id = 1,
        //            Title = "The Matrix",
        //            Description = "There is no spoon etc",
        //            Rating = 8,
        //            YearOfRelease = new DateTime(1999,1,1),
        //            Genres = new Genre[] { Genre.Action, Genre.SciFi }
        //        },
        //        new Movie
        //        {
        //            Id = 2,
        //            Title = "Treasure Planet",
        //            Description = "Space surfing with pirates",
        //            Rating = 10,
        //            YearOfRelease = new DateTime(2002,1,1),
        //            Genres = new Genre[] { Genre.Animation, Genre.Adventure, Genre.Family}
        //        },
        //        new Movie
        //        {
        //            Id = 3,
        //            Title = "The Lion King",
        //            Description = "Lion family drama",
        //            Rating = 9,
        //            YearOfRelease = new DateTime(1994,1,1),
        //            Genres = new Genre[] {  Genre.Animation, Genre.Adventure, Genre.Drama}
        //        },
        //        new Movie
        //        {
        //            Id = 4,
        //            Title = "Back to the Future: The actual Future",
        //            Description = "Hasn't happened yet so who knows?",
        //            Rating = 10,
        //            YearOfRelease = new DateTime(2054,12,12),
        //            Genres = new Genre[] {  Genre.Horror, Genre.Thriller, Genre.Drama}
        //        }
        //    };
        //}


    }
}
