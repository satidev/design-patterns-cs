namespace HeadFirst._01Strategy;

public class StrategyDemo
{
    public static void Run()
    {
        Duck mallard = new MallardDuck();
        mallard.Display();
        mallard.PerformQuack();
        mallard.PerformFly();
        mallard.Swim();
        
        Duck model = new ModelDuck();
        model.Display();
        model.PerformQuack();
        model.PerformFly();
        model.Swim();
        
        Duck rubber = new RubberDuck();
        rubber.Display();
        rubber.PerformQuack();
        rubber.PerformFly();
        rubber.Swim();
        
        rubber.SetQuackBehaviour(new Squeak());
        rubber.PerformQuack();
    }
}