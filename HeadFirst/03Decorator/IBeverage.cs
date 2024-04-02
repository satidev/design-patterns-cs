namespace HeadFirst._03Decorator;

// Entity that is going to be decorated.
public interface IBeverage
{
    public string Description();
    public double Cost();
}

public class Espresso : IBeverage
{
    public string Description() => "Espresso";
    public double Cost() => 1.99;
}

public class HouseBlend : IBeverage
{
    public string Description() => "House Blend Coffee";
    public double Cost() => 0.89;
}

public class DarkRoast : IBeverage
{
    public string Description() => "Dark Roast Coffee";
    public double Cost() => 1.00;
}

public class Decaf : IBeverage
{
    public string Description() => "Decaf Coffee";
    public double Cost() => 1.05;
}