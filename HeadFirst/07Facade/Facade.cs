namespace HeadFirst._07Facade;

public class Facade
{
    public void SimplifiedInterface()
    {
        Subsystem subsystem = new Subsystem();
        subsystem.Operation1();
        subsystem.Operation2();
        subsystem.Operation3();
        subsystem.Operation4();
    }
}