namespace HeadFirst._08TemplateMethod;

public class Tee: CaffeineDrink
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }
}
