using IntroToASPMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroToASPMVC.Services
{
    public interface IMovieService
    {
        Task AddMovieAsync(Movie movie);
        Task DeleteMovieAsync(Movie movie);
        Task<Movie> GetMovieAsync(int id);
        Task<ICollection<Movie>> GetMoviesAsync();        
        Task UpdateMovieAsync(Movie movie);
    }
}