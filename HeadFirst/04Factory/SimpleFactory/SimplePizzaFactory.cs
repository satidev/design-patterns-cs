namespace HeadFirst._04Factory.SimpleFactory;

public class SimplePizzaFactory
{
    public Pizza CreatePizza()
    {
        return new NyStyleCheesePizza();
    }    
}