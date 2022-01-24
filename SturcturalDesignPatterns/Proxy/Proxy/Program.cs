public interface name
{
    void display();
}
class originalname : name
{
    private string Variable;
    private string v;

    public originalname(string variable)
    {
        this.Variable = variable;
    }

    public void display()
    {
        System.Console.WriteLine("Original name: "+ Variable);
    }
}
class proxyname: name
{
    private originalname originalname;
    private string Variable;
    public proxyname(string Variable)
    {
        this.Variable = Variable;
    }
    public void display()
    {
        if (originalname == null)
        {
            originalname = new originalname(Variable);
        }
        originalname.display();
    }
}
class program
{
    static void Main()
    {
        //name Name1 = new originalname("Sangeetha");
        name Name= new proxyname("Sangeetha");
        Name.display();
    }
}