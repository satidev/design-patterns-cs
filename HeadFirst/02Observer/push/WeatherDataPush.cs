namespace HeadFirst._02Observer.push;

public class WeatherDataPush: ISubjectPush
{
    private List<IObserverPush> _observers = new List<IObserverPush>();
    private float _temperature = 0.0f;
    private float _humidity = 0.0f;
    private float _pressure = 0.0f;
    
    public WeatherDataPush()
    {

    }
    
    public void RegisterObserver(IObserverPush observerPush)
    {
        _observers.Add(observerPush);
    }
    
    public void RemoveObserver(IObserverPush observerPush)
    {
        _observers.Remove(observerPush);
    }
    
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
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
    
}