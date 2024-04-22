namespace HeadFirst._05Singleton;

public class SingletonDemo
{
    public static void Run()
    {
        Database db1 = Database.GetInstance();
        Database db2 = Database.GetInstance();
        Database db3 = Database.GetInstance();
    }
}