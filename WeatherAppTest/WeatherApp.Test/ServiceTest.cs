using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherApp.Services;

namespace WeatherApp.Test
{
    public class ServiceTests
    {
        ICountryService _countryService;
        ICityService _cityService;
        IWeatherService _weatherService;

        public ServiceTests()
        {
            _countryService = new CountryService();
            _cityService = new CityService();
            _weatherService = new WeatherService();
        }

        [Test]
        public void CountrySericeTest()
        {
            List<Country> _lstCountry = _countryService.GetAll();

            Assert.IsTrue(_lstCountry.Count > 0);
        }

        [Test]
        public void CitySericeTest()
        {
            List<City> _lstCity = _cityService.GetCityByCountry("USA");

            Assert.IsTrue(_lstCity.Count > 0);
        }

        [Test]
        public async Task WeatherSericeTest()
        {
            Weather weather = await _weatherService.GetWeather("Detroit");

            Assert.IsNotNull(weather);
        }
    }
}