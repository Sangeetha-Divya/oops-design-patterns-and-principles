//We have created classes Memento, Originator and CareTaker.
public class Originator
{
    string state;
    public string State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("State = " + state);
        }
    }
    public Memento Create()
    {
        return (new Memento(state));
    }
    public void store(Memento memento)
    {
        Console.WriteLine("Restoring state...");
        State = memento.State;
    }
}
public class Memento
{
    string state;
    public Memento(string state)
    {
        this.state = state;
    }
    public string State
    {
        get { return state; }
    }
}
public class Caretaker
{
    Memento memento;
    public Memento Memento
    {
        set { memento = value; }
        get { return memento; }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Originator o = new Originator();
        o.State = "On";
        Caretaker c = new Caretaker();
        c.Memento = o.Create();
        o.State = "Off";
        o.store(c.Memento);
    }
}