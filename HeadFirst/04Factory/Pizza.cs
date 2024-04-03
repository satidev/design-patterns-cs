namespace HeadFirst._04Factory;

public abstract class Pizza
{
    protected string _name = "";
    protected string _dough = "";
    protected string _sauce = "";
    protected List<string> _toppings = new List<string>();

    public void Prepare()
    {
        Console.WriteLine("Preparing " + _name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        foreach (var topping in _toppings)
        {
            Console.WriteLine("   " + topping);
        }
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public void Cut()
    {
       Console.WriteLine("Cutting the pizza into diagonal slices"); 
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
    
    public string GetName() => _name;
}

public class NyStyleCheesePizza : Pizza
{
    public NyStyleCheesePizza()
    {
        _name = "NY Style Sauce and Cheese Pizza";
        _dough = "Thin Crust Dough";
        _sauce = "Marinara Sauce";
        _toppings.Add("Grated Reggiano Cheese");
    }
}

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        _name = "Chicago Style Deep Dish Cheese Pizza";
        _dough = "Extra Thick Crust Dough";
        _sauce = "Plum Tomato Sauce";
        _toppings.Add("Shredded Mozzarella Cheese");
    }

    public new void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}

