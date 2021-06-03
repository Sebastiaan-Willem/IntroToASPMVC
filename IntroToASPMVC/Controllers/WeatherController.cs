using IntroToASPMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroToASPMVC.Controllers
{
    public class WeatherController : Controller
    {
        private IWeatherService _service;

        public WeatherController(IWeatherService service)
        {
            _service = service;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var model = await _service.GetWeatherModel("Gent");
            return View(model);
        }
    }
}
