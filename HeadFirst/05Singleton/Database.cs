namespace HeadFirst._05Singleton;

// Add a Database class to the Singleton namespace.
public class Database
{
    private static readonly Database instance = new Database();
    private static int _count = 0;

    private Database()
    {
        _count++;
        Console.WriteLine($"Database instance created {_count} times.");
    }
    // Thread-safe implementation of the Singleton pattern.
    public static Database GetInstance()
    {
        return instance;
    }    
}