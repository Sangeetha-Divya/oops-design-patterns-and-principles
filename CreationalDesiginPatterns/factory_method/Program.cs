interface laptop
{
    public abstract void brand();
}
class hp: laptop
{
    public void brand()
    {
        System.Console.WriteLine("This is Hp laptop");
    }
}
class lenova: laptop
{
    public void brand()
    {
        System.Console.WriteLine("This is a lenova laptop");
    }
}
class factory
{
    public laptop Select_brand(string BrandName)
    {
        if (BrandName == "HP")
            return new hp();
        else if (BrandName =="lenova")
            return new lenova();
        return null;
    }
}
class program
{
    static void Main()
    {
        factory Factory = new factory();
        laptop l1 = Factory.Select_brand("HP");
        l1.brand();
        laptop l2 = Factory.Select_brand("lenova");
        l2.brand();
    }
}