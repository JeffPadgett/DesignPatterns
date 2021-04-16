using System;
using System.Collections.Generic;
namespace WeatherStationClassLib
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData() {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver (IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged() 
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float hum, float press)
        {
            this.temperature = temp;
            this.humidity = hum;
            this.pressure = press;
            MeasurementsChanged();
        }
    }

}