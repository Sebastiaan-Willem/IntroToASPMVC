using AutoMapper;
using GenericLibrary;
using IntroToASPMVC.Data;
using IntroToASPMVC.Data.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Services
{
    public class WeatherService : IWeatherService
    {
        private IWeatherRepository _repo;
        private IMapper _mapper;

        public WeatherService(IWeatherRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Models.Weather> GetWeatherModel(string city)
        {
            WeatherEntity entity = await _repo.GetWeatherEntityAsync(city);
            Models.Weather model = _mapper.Map<Models.Weather>(entity);

            //use our generic library to convert the data to a different unit
            model.Temperature = TemperatureConverter.KelvinToCelsius(model.Temperature);
            model.Temperature = TemperatureConverter.KelvinToCelsius(model.MinTemperature);
            model.Temperature = TemperatureConverter.KelvinToCelsius(model.MaxTemperature);

            return model;
        }
    }
}
