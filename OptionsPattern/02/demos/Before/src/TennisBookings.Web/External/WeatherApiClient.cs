using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TennisBookings.Web.External.Models;
using Microsoft.Extensions.Configuration;

namespace TennisBookings.Web.External
{
    public class WeatherApiClient : IWeatherApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<WeatherApiClient> _logger;

        public WeatherApiClient(HttpClient httpClient, IConfiguration config, ILogger<WeatherApiClient> logger)
        {
            var url = config["ExternalServices:WeatherApiUrl"];

            httpClient.BaseAddress = new Uri(url);

            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<WeatherApiResult> GetWeatherForecastAsync()
        {
            const string path = "api/currentWeather/Brighton";

            try
            {
                var response = await _httpClient.GetAsync(path);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var content = await response.Content.ReadAsAsync<WeatherApiResult>();

                return content;
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, "Failed to get weather data from API");
            }

            return null;
        }
    }
}
