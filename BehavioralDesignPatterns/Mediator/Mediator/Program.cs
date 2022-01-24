public abstract class Message
{
    public abstract void Send(string message, Colleague colleague);
}
public class text_message : Message
{
    ConcreteColleague1 colleague1;
    ConcreteColleague2 colleague2;
    public ConcreteColleague1 Colleague1
    {
        set { colleague1 = value; }
    }
    public ConcreteColleague2 Colleague2
    {
        set { colleague2 = value; }
    }
    public override void Send(string message, Colleague colleague)
    {
        if (colleague == colleague1)
        {
            colleague2.Notify(message);
        }
        else
        {
            colleague1.Notify(message);
        }
    }
}

public abstract class Colleague
{
    protected Message message;
    // Constructor
    public Colleague(Message message)
    {
        this.message = message;
    }
}
public class ConcreteColleague1 : Colleague
{
    // Constructor
    public ConcreteColleague1(Message message)
        : base(message)
    {
    }
    public void Send(string text)
    {
        message.Send(text, this);
    }
    public void Notify(string message)
    {
        Console.WriteLine("Colleague1 gets message: "
            + message);
    }
}
public class ConcreteColleague2 : Colleague
{
    // Constructor
    public ConcreteColleague2(Message message)
        : base(message)
    {
    }
    public void Send(string text)
    {
        message.Send(text, this);
    }
    public void Notify(string message)
    {
        Console.WriteLine("Colleague2 gets message: "
            + message);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        text_message m = new text_message();
        ConcreteColleague1 c1 = new ConcreteColleague1(m);
        ConcreteColleague2 c2 = new ConcreteColleague2(m);
        m.Colleague1 = c1;
        m.Colleague2 = c2;
        c1.Send("HI");
        c2.Send("Hello");
    }
}