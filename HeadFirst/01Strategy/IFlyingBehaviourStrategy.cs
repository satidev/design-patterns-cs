namespace HeadFirst._01Strategy;

public interface IFlyingBehaviourStrategy
{
    public void Fly();    
}

// Path: HeadFirst/01Strategy/IMakeSoundBehaviour.cs

// Implementations of IFlyingBehaviour


public class FlyWithWings : IFlyingBehaviourStrategy
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with wings!");
    }
}

public class FlyNoWay : IFlyingBehaviourStrategy
{
    public void Fly()
    {
        Console.WriteLine("I can't fly!");
    }
}

