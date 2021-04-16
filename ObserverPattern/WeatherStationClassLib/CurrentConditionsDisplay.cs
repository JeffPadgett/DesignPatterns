using System;
using static System.Console;

namespace WeatherStationClassLib
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float tempature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData wd)
        {
            this.weatherData = wd;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humid, float press)
        {
            this.tempature = temp;
            this.humidity = humid;
            Display();
        }

        public void Display()
        {
            WriteLine($"Current conditions: {tempature}F degrees and {humidity}% humidity");
        }

    }
} 