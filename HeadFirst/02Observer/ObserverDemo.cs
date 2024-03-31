using HeadFirst._02Observer.pull;
using HeadFirst._02Observer.push;

namespace HeadFirst._02Observer;

public class ObserverDemo
{
    public static void Run()
    {
        WeatherDataPush weatherDataPush = new WeatherDataPush();
        CurrentConditionsDisplayPush currentDisplayPush = new CurrentConditionsDisplayPush(weatherDataPush);

        weatherDataPush.SetMeasurements(80, 65, 30.4f);
        weatherDataPush.SetMeasurements(82, 70, 29.2f);
        weatherDataPush.SetMeasurements(78, 90, 29.2f);
        
        WeatherDataPull weatherDataPull = new WeatherDataPull();
        CurrentConditionsDisplayPull currentDisplayPull = new CurrentConditionsDisplayPull(weatherDataPull);

        weatherDataPull.SetMeasurements(80, 65, 30.4f);
        weatherDataPull.SetMeasurements(82, 70, 29.2f);
        weatherDataPull.SetMeasurements(78, 90, 29.2f);        
    }
}