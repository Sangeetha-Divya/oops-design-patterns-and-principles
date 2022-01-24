public interface IMessage
{
    void SendMessage();
}
public class Email : IMessage
{
    public void SendMessage()
    {
        Console.WriteLine("Send email");
    }
}

public class SMS : IMessage
{
    public void SendMessage()
    {
        Console.WriteLine("Send SMS");
    }
}
public class DIP
{
    IMessage message;

    public DIP(IMessage message)
    {
        this.message = message;
    }
    public void SendMessage()
    {
        message.SendMessage();
    }
}
class program
{
    static void Main()
    {
        IMessage msg = new SMS();
        IMessage msg2 = new Email();
        msg.SendMessage();
        msg2.SendMessage(); 
    }
}
