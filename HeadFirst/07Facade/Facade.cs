namespace HeadFirst._07Facade;

public class Facade
{
    public void SimplifiedInterface()
    {
        Subsystem subsystem = new Subsystem();
        subsystem.operation1();
        subsystem.operation2();
        subsystem.operation3();
        subsystem.operation4();
    }
}