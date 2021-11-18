using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly ICityService _cityService;
        private readonly IWeatherService _weatherService;

        public WeatherController(ICountryService countryService, ICityService cityService, IWeatherService weatherService)
        {
            _countryService = countryService;
            _cityService = cityService;
            _weatherService = weatherService;
        }

        [HttpGet("GetCountry")]
        public IEnumerable<Country> GetCountry()
        {
            return _countryService.GetAll();
        }

        [HttpGet("GetCity/{country}")]
        public IEnumerable<City> GetCity(string country)
        {
            return _cityService.GetCityByCountry(country);
        }

        [HttpGet("getweather/{city}")]
        public async Task<Weather> GetWeather(string city)
        {
            var retval = await _weatherService.GetWeather(city);

            return retval;
        }
    }
}
