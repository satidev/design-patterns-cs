namespace HeadFirst._08TemplateMethod;

public abstract class CaffeineDrink
{
    //Public template method that defines the algorithm.
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }
    private void BoilWater()
    {
        System.Console.WriteLine("Boiling water");
    }
    private void PourInCup()
    {
        System.Console.WriteLine("Pouring into cup");
    }
    protected abstract void Brew();
    protected abstract void AddCondiments();
}