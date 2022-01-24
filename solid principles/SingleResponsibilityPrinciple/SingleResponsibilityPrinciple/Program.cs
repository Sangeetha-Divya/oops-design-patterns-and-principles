interface Isrp
{
    void start();
    void stop();
    void perform();
}
class Sample
{
    Isrp srp;
    public Sample(Isrp srp)
    {
        this.srp = srp;
    }
    public void open()
    {
        srp.start();
    }
    public void close()
    {
        srp.stop();
    }
    public void DO()
    {
        srp.perform();
    }
}
class implement : Isrp
{
    public void perform()
    {
        Console.WriteLine("I am performing...");
    }

    public void start()
    {
        Console.WriteLine("I am Start...");
    }

    public void stop()
    {
        Console.WriteLine("I am stop...");
    }
}
class program
{
    static void Main()
    {
        implement implement = new implement();
        implement.start(); 
        implement.perform();
        implement.stop();
    }
}