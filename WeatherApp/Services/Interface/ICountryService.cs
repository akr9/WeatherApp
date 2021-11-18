using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public interface ICountryService
    {
        List<Country> GetAll();
    }
}
