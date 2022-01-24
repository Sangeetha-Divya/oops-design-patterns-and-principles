public sealed class Singleton
{
    private static Singleton instance= new Singleton();
    public static Singleton getinstance()
    {
        return instance;
    }
    private Singleton() { }
    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Singleton s1 = Singleton.getinstance();
        s1.PrintDetails("From s1");
        Singleton s2 = Singleton.getinstance();
        s2.PrintDetails("From s2");
    }
}