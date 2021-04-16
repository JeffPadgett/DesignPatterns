using System;

namespace WeatherStationClassLib
{
    public interface ISubject 
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }
} 