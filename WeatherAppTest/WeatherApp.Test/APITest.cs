using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Controllers;
using WeatherApp.Services;

namespace WeatherApp.Test
{
    public class APITests
    {
        WeatherController _controller;
        ICountryService _countryService;
        ICityService _cityService;
        IWeatherService _weatherService;

        public APITests()
        {
            _countryService = new CountryService();
            _cityService = new CityService();
            _weatherService = new WeatherService();
            _controller = new WeatherController(_countryService, _cityService, _weatherService);
        }

        [Test]
        public void GetCountryTest()
        {
            var createdResponse = _controller.GetCountry();

            Assert.IsNotEmpty(createdResponse);
        }

        [Test]
        public void getCityTest()
        {
            var createdResponse = _controller.GetCity("USA");

            Assert.IsNotEmpty(createdResponse);
        }

        [Test]
        public async Task GetWeatherTest()
        {
            var createdResponse = await _controller.GetWeather("Detroit");

            Assert.IsNotNull(createdResponse, "error");
        }
    }
}