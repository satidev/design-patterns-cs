namespace HeadFirst._04Factory.FactoryMethod;

public abstract class PizzaStore
{
    public Pizza OrderPizza()
    {
        Pizza pizza = CreatePizza();

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    // Factory method.
    public abstract Pizza CreatePizza();

}

public class NyPizzaStore : PizzaStore
{
    public override Pizza CreatePizza()
    {
        return new NyStyleCheesePizza();
    }
}

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza()
    {
        return new ChicagoStyleCheesePizza();
    }
}