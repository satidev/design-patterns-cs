namespace HeadFirst._02Observer.pull;

public interface ISubjectPull
{
    void RegisterObserver(IObserverPull observerPush);
    void RemoveObserver(IObserverPull observerPush);
    void NotifyObservers();        
}