using System;
using static System.Console;
using WeatherStationClassLib;

namespace WeatherStationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
            weatherData.SetMeasurements(80,65, 30.4f);
            
            
        }
    }
}
