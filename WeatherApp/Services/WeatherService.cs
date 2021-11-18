using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private string _url;
        private string _key = "566344d5cd2efdb38b2c3d1f3cb3dc3f";
        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Weather> GetWeather(string city)
        {
            try
            {
                _url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_key}";
                var requestUrl = new Uri(_url);
                var response = await _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<Weather>(data);
            }
            catch (System.Exception ex)
            {
                var err = ex.Message.ToString();
                throw new SystemException(err);
            }
        }
    }
}
