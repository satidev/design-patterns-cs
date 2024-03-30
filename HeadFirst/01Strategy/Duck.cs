namespace HeadFirst._01Strategy;

public abstract class Duck
{
    private IQuackBehaviourStrategy _quackBehaviourStrategy;
    private IFlyingBehaviourStrategy _flyingBehaviourStrategy;
    
    protected Duck(IQuackBehaviourStrategy quackBehaviourStrategy,
        IFlyingBehaviourStrategy flyingBehaviourStrategy)
    {
        this._quackBehaviourStrategy = quackBehaviourStrategy;
        this._flyingBehaviourStrategy = flyingBehaviourStrategy;
    }

    public void PerformQuack()
    {
        _quackBehaviourStrategy.Quack();
    }

    public void PerformFly()
    {
        _flyingBehaviourStrategy.Fly();
    }

    public void Swim()
    {
        Console.WriteLine("I'm swimming!");
    }

    public abstract void Display();

    public void SetQuackBehaviour(IQuackBehaviourStrategy quackBehaviourStrategy)
    {
        this._quackBehaviourStrategy = quackBehaviourStrategy;
    }

    public void SetFlyingBehaviour(IFlyingBehaviourStrategy flyingBehaviourStrategy)
    {
        this._flyingBehaviourStrategy = flyingBehaviourStrategy;
    }
}

public class MallardDuck : Duck
{
    public MallardDuck() : base(new NormalQuack(), new FlyWithWings())
    {
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Mallard Duck!");
    }
}

public class ModelDuck : Duck
{
    public ModelDuck() : base(new NormalQuack(), new FlyNoWay())
    {
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Model Duck!");
    }
}

public class RubberDuck : Duck
{
    public RubberDuck() : base(new Squeak(), new FlyNoWay())
    {
    }

    public override void Display()
    {
        Console.WriteLine("I'm a Rubber Duck!");
    }
}