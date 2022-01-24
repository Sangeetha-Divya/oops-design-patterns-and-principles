//composition has  a strong assosication
//Without existing container object if there is no chance of existing contained objects
//Composition is more flexible and is a means to designing loosely coupled applications.
//car has engine
// humans have brain/heart
class brain
{
    public void has_brain()
    {
        System.Console.WriteLine("I am having brain....");
    }
}
class human
{
    brain Brain = new brain();//human has a brain
    public void Human()
    {
        System.Console.WriteLine("I am Human");
        Brain.has_brain();
    }
}
class program
{
    public static void Main()
    {
        human human = new human(); 
        human.Human();
    }
}