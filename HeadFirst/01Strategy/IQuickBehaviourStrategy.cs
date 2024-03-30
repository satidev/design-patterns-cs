namespace HeadFirst._01Strategy;

public interface IQuackBehaviourStrategy
{
    public void Quack();
}

public class NormalQuack : IQuackBehaviourStrategy
{
    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}

public class Squeak : IQuackBehaviourStrategy
{
    public void Quack()
    {
        Console.WriteLine("Squeak!");
    }
}

public class MuteQuack : IQuackBehaviourStrategy
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}