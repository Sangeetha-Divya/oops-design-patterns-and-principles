public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
public interface IObserver
{
    void update(string availability);
}
public class Subject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string ProductName { get; set; }
    private int ProductPrice { get; set; }
    private string Availability { get; set; }
    public Subject(string productName, int productPrice, string availability)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        Availability = availability;
    }

    public string getAvailability()
    {
        return Availability;
    }
    public void setAvailability(string availability)
    {
        this.Availability = availability;
        Console.WriteLine("Availability changed from Out of Stock to Available.");
        NotifyObservers();
    }
    public void RegisterObserver(IObserver observer)
    {
        Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
        observers.Add(observer);
    }
    public void AddObservers(IObserver observer)
    {
        observers.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        Console.WriteLine("Product Name :"
                        + ProductName + ", product Price : "
                        + ProductPrice + " is Now available. So notifying all Registered users ");
        Console.WriteLine();
        foreach (IObserver observer in observers)
        {
            observer.update(Availability);
        }
    }
}
public class Observer : IObserver
{
    public string UserName { get; set; }
    public Observer(string userName, ISubject subject)
    {
        UserName = userName;
        subject.RegisterObserver(this);
    }

    public void update(string availabiliy)
    {
        Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
        Subject Samsang = new Subject("Silver Samsung", 20000, "Out of Stock");
        Observer user1 = new Observer("Anurag", RedMI);
        Observer user2 = new Observer("Pranaya", RedMI);
        Observer user3 = new Observer("Priyanka", Samsang);

        Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
        Console.WriteLine();
        RedMI.setAvailability("Available");
        Console.Read();
    }
}