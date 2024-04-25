namespace HeadFirst._08TemplateMethod;

public class Coffee: CaffeineDrink
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }
}
