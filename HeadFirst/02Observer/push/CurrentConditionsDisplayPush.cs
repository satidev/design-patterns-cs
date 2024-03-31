namespace HeadFirst._02Observer.push;

public class CurrentConditionsDisplayPush: IObserverPush, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private WeatherDataPush _weatherDataPush;

    public CurrentConditionsDisplayPush(WeatherDataPush weatherDataPush)
    {
        _weatherDataPush = weatherDataPush;
        weatherDataPush.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }    
}