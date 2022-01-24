//generally multiple inhertance cannot implemented 
//however using interfaces we can implement it

interface bachelor_degree1
{
    public abstract void be();
}
interface bachelor_degree2
{
    public abstract void btech();
}
class degree: bachelor_degree1, bachelor_degree2 //multiple inhertance
{
    public virtual void be()
    {
        System.Console.WriteLine("I am BE Student");
    }
    public virtual void btech()
    {
        System.Console.WriteLine("I am an B.Tech Student");
    }
}
class btech_dept:bachelor_degree2
{

    public void ece(string name)
    {
        System.Console.WriteLine("I am {} from ece");
    }
    public void cse(string name)
    {
        System.Console.WriteLine("I am {} from cse");
    }

    public void btech()
    {
        System.Console.WriteLine("I am b.tech student");
    }
}
class program
{
    public static void Main()
    {
        degree obj=new degree();
        btech_dept btech_Dept = new btech_dept();
        obj.be();
        obj.btech();
        btech_Dept.btech();
        btech_Dept.ece("Sangeetha");
    }
}