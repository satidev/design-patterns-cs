namespace HeadFirst._03Decorator;

// Decorator of the IBeverage.
public abstract class CondimentDecorator : IBeverage
{
    protected readonly IBeverage _beverage;
    public abstract string Description();
    public abstract double Cost();

    protected CondimentDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }
}

public class Mocha : CondimentDecorator
{
    public Mocha(IBeverage beverage) : base(beverage)
    {
    }

    public override string Description() => _beverage.Description() + ", Mocha";
    public override double Cost() => _beverage.Cost() + 0.20;
}

public class Whip : CondimentDecorator
{
    public Whip(IBeverage beverage) : base(beverage)
    {
    }

    public override string Description() => _beverage.Description() + ", Whip";
    public override double Cost() => _beverage.Cost() + 0.10;
}

public class Soy : CondimentDecorator
{
    public Soy(IBeverage beverage) : base(beverage)
    {
    }

    public override string Description() => _beverage.Description() + ", Soy";
    public override double Cost() => _beverage.Cost() + 0.15;
}