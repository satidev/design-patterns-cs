namespace HeadFirst._04Factory.FactoryMethod;

public class FactoryMethodDemo
{
    public static void Run()
    {
        PizzaStore nyStore = new NyPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.OrderPizza();
        Console.WriteLine($"Ethan ordered a {pizza.GetName()}\n");

        pizza = chicagoStore.OrderPizza();
        Console.WriteLine($"Joel ordered a {pizza.GetName()}\n");
    }
}