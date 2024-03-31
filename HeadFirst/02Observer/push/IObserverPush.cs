namespace HeadFirst._02Observer.push;
// Push observer or subscriber is going to observe the subject.
public interface IObserverPush
{
    public void Update(float temp, float humidity, float pressure);    
}