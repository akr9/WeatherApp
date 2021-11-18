using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class CityService : ICityService
    {
        private List<City> _lstCity;

        public CityService()
        {
            var json = System.IO.File.ReadAllText("Data/City.json");
            _lstCity = JsonConvert.DeserializeObject<List<City>>(json);
        }

        public List<City> GetCityByCountry(string country)
        {
            return _lstCity.Where(x => x.CountryName.ToLower() == country.ToLower()).ToList();
        }
    }
}
