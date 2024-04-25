namespace HeadFirst._08TemplateMethod;

public class TemplateMethodDemo
{
    public static void Run()
    {
        System.Console.WriteLine("Preparing coffee...");
        CaffeineDrink coffee = new Coffee();
        coffee.PrepareRecipe();

        System.Console.WriteLine("Preparing tee...");
        CaffeineDrink tee = new Tee();
        tee.PrepareRecipe();
    }
}