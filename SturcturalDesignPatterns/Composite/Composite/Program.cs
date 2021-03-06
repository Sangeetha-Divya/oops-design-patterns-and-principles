public interface IComponent
{
    void DisplayPrice();
}
public class Leaf : IComponent
{
    public int Price { get; set; }
    public string Name { get; set; }
    public Leaf(string name, int price)
    {
        this.Price = price;
        this.Name = name;
    }

    public void DisplayPrice()
    {
        Console.WriteLine(Name + " : " + Price);
    }
}
public class Composite : IComponent
{
    public string Name { get; set; }
    List<IComponent> components = new List<IComponent>();
    public Composite(string name)
    {
        this.Name = name;
    }
    public void AddComponent(IComponent component)
    {
        components.Add(component);
    }

    public void DisplayPrice()
    {
        Console.WriteLine(Name);
        foreach (var item in components)
        {
            item.DisplayPrice();
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        IComponent mouse = new Leaf("Mouse", 2000);
        IComponent keyboard = new Leaf("Keyboard", 2000);
        Composite motherBoard = new Composite("Peripherals");
        Composite computer = new Composite("Computer");
        computer.AddComponent(mouse);
        computer.AddComponent(keyboard);
        computer.AddComponent(motherBoard);
        mouse.DisplayPrice();
        keyboard.DisplayPrice();
    }
}