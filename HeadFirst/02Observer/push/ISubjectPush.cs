namespace HeadFirst._02Observer.push;

// Subject or publisher is going to be observed by observers.
public interface ISubjectPush
{
    void RegisterObserver(IObserverPush observerPush);
    void RemoveObserver(IObserverPush observerPush);
    void NotifyObservers();    
}