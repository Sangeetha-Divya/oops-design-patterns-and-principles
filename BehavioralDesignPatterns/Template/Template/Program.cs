public abstract class CoffeeTemplate
{
    public void PrepareCoffee()
    {
        BoilWater();
        AddMilk();
        AddSugar();
        AddCoffeePowder();
        Console.WriteLine(this.GetType().Name + " is Ready");
    }
    protected abstract void BoilWater();
    protected abstract void AddMilk();
    protected abstract void AddSugar();
    protected abstract void AddCoffeePowder();
}
public class BruCoffee : CoffeeTemplate
{
    protected override void BoilWater()
    {
        Console.WriteLine("Water Boild");
    }
    protected override void AddMilk()
    {
        Console.WriteLine("Milk Added");
    }
    protected override void AddSugar()
    {
        Console.WriteLine("Sugar Added");
    }
    protected override void AddCoffeePowder()
    {
        Console.WriteLine("Bru Coffee Powder Added");
    }
}
public class NescafeCoffee : CoffeeTemplate
{
    protected override void BoilWater()
    {
        Console.WriteLine("Water Boild");
    }
    protected override void AddMilk()
    {
        Console.WriteLine("Milk Added");
    }
    protected override void AddSugar()
    {
        Console.WriteLine("Sugar Added");
    }
    protected override void AddCoffeePowder()
    {
        Console.WriteLine("Nescafe Coffee Powder Added");
    }
}
class program
{
    static void Main()
    {
        NescafeCoffee nescafeCoffee = new NescafeCoffee();
        BruCoffee bruCoffee = new BruCoffee();
        nescafeCoffee.PrepareCoffee();
        System.Console.WriteLine(" ");
        bruCoffee.PrepareCoffee();
    }
}