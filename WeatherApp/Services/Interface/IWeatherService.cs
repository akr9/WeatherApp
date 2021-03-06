using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetWeather(string city);
    }
}
