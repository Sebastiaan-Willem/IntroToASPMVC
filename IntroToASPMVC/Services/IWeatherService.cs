using IntroToASPMVC.Models;
using System.Threading.Tasks;

namespace IntroToASPMVC.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetWeatherModel(string city);
    }
}