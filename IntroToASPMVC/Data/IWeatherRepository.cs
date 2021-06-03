using IntroToASPMVC.Data.Weather;
using System.Threading.Tasks;

namespace IntroToASPMVC.Data
{
    public interface IWeatherRepository
    {
        Task<WeatherEntity> GetWeatherEntityAsync(string city);
    }
}