using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class CountryService : ICountryService
    {
        private List<Country> _lstCountry;

        public CountryService()
        {
            var json = System.IO.File.ReadAllText("Data/Country.json");
            _lstCountry = JsonConvert.DeserializeObject<List<Country>>(json);
        }

        public List<Country> GetAll()
        {
            return _lstCountry;
        }
    }
}
