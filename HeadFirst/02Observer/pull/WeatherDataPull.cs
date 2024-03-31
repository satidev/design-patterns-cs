using HeadFirst._02Observer.push;

namespace HeadFirst._02Observer.pull;

public class WeatherDataPull : ISubjectPull
{
    private List<IObserverPull> _observers = new List<IObserverPull>();
    private float _temperature = 0.0f;
    private float _humidity = 0.0f;
    private float _pressure = 0.0f;

    public void RegisterObserver(IObserverPull observerPush)
    {
        _observers.Add(observerPush);
    }

    public void RemoveObserver(IObserverPull observerPush)
    {
        _observers.Remove(observerPush);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;

        MeasurementsChanged();
    }
    
    public float GetTemperature()
    {
        return _temperature;
    }
    
    public float GetHumidity()
    {
        return _humidity;
    }
}