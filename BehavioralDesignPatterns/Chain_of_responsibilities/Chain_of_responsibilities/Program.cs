public abstract class Handlerbase
{
    public Handlerbase NextTeam { get; private set; }
    public abstract void HandleRequest();
    public Handlerbase(Handlerbase nextHandler)
    {
        NextTeam = nextHandler;
    }
}
public class TeamOne : Handlerbase
{
    public TeamOne(Handlerbase nextHandler) : base(nextHandler)
    {
    }

    public override void HandleRequest()
    {
        Console.WriteLine("Wating for team one to respond");
        Console.WriteLine("\t no response from team one.....");

        NextTeam.HandleRequest();
    }
}
public class TeamTwo : Handlerbase
{
    public TeamTwo(Handlerbase nextHandler) : base(nextHandler)
    {
    }

    public override void HandleRequest()
    {
        Console.WriteLine("Wating for team two to respond");
        Console.WriteLine("\t no response from team two.....");
        NextTeam.HandleRequest();
    }
}

class program
{ 
    static void Main(string[] args)
    {
    TeamTwo teamTwo = new TeamTwo(null);
    TeamOne teamOne = new TeamOne(teamTwo);

    teamOne.HandleRequest();
    Console.ReadKey();
    }
}