namespace HeadFirst._03Decorator;

public class DecoratorDemo
{
    public static void Run()
    {
        IBeverage beverage = new DarkRoast();
        Console.WriteLine($"{beverage.Description()} ${beverage.Cost()}");

        IBeverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine($"{beverage2.Description()} ${beverage2.Cost()}");
    }
}