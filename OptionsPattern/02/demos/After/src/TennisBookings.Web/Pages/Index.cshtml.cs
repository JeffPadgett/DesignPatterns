using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using TennisBookings.Web.Services;

namespace TennisBookings.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWeatherForecaster _weatherForecaster;
        private readonly IGreetingService _greetingService;
        private readonly IConfiguration _configuration;

        public IndexModel(
            IWeatherForecaster weatherForecaster,
            IGreetingService greetingService,
            IConfiguration configuration)
        {
            _weatherForecaster = weatherForecaster;
            _greetingService = greetingService;
            _configuration = configuration;
        }

        public string Greeting { get; private set; }
        public bool ShowGreeting => !string.IsNullOrEmpty(Greeting);
        public string ForecastSectionTitle { get; private set; }
        public string WeatherDescription { get; private set; }
        public bool ShowWeatherForecast { get; private set; }

        public async Task OnGet()
        {
            var features = new Features();
            _configuration.Bind("Features:HomePage", features);

            if (features.EnableGreeting)
            {
                Greeting = _greetingService.GetRandomGreeting();
            }

            ShowWeatherForecast = features.EnableWeatherForecast
                && _weatherForecaster.ForecastEnabled;

            if (ShowWeatherForecast)
            {
                var title = features.ForecastSectionTitle;
                ForecastSectionTitle = string.IsNullOrEmpty(title) ? "How's the weather?" : title;

                var currentWeather = await _weatherForecaster.GetCurrentWeatherAsync();

                if (currentWeather != null)
                {
                    switch (currentWeather.Description)
                    {
                        case "Sun":
                            WeatherDescription = "It's sunny right now. A great day for tennis!";
                            break;

                        case "Cloud":
                            WeatherDescription = "It's cloudy at the moment and the outdoor courts are in use.";
                            break;

                        case "Rain":
                            WeatherDescription = "We're sorry but it's raining here. No outdoor courts in use.";
                            break;

                        case "Snow":
                            WeatherDescription = "It's snowing!! Outdoor courts will remain closed until the snow has cleared.";
                            break;
                    }
                }
            }
        }

        private class Features
        {
            public bool EnableGreeting { get; set; }
            public bool EnableWeatherForecast { get; set; }
            public string ForecastSectionTitle { get; set; }
        }
    }
}
