//hiding internal details
//hides unwanted or unneccesary details
//abstract methods doesn't have body
//abstract class cannot be instantiated
//for example: coffee machine
//we should know how to operate it and there is no need to know how it internally works
abstract class CoffeeMachineFunctionallity
{
    public abstract void Grind();
    public void start()
    {
        System.Console.WriteLine("Start filling...");
    }
    public void stop()
    {
        System.Console.WriteLine("Stop filling...");
    }
}
class process: CoffeeMachineFunctionallity
{
    public override void Grind()
    {
        System.Console.WriteLine("Processing....");
    }
}
class program
{
    public static void Main()
    {
        process process = new process();
        process.Grind();
        process.start();
        process.stop();
    }
}
