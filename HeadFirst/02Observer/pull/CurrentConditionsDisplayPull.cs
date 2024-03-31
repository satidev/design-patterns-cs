namespace HeadFirst._02Observer.pull;

public class CurrentConditionsDisplayPull: IObserverPull, IDisplayElement
{
    private WeatherDataPull _weatherDataPull;

    public CurrentConditionsDisplayPull(WeatherDataPull weatherDataPull)
    {
        _weatherDataPull = weatherDataPull;
        weatherDataPull.RegisterObserver(this);
    }

    public void Update()
    {
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_weatherDataPull.GetTemperature()}F degrees and {_weatherDataPull.GetHumidity()}% humidity");
    }        
}