//inheritacnce means accquiring properties from a class to other
//multiple inheritance can be acheived by interfaces
class father
{
    public void house()
    {
        System.Console.WriteLine("Father's house");
    }
}
class mother
{
    public void gold()
    {
        System.Console.WriteLine("Mother's gold");
    }
}
class son: father    //single line inheritance
{
    public void bike()
    {
        System.Console.WriteLine("Son' bike");
    }
}
class daugther : son  //multi level inheritance
{
    public void laptop()
    {
        System.Console.WriteLine("Daughter's laptop");
    }
}
class program
{
    public static void Main()
    {
        father father = new father();
        son son = new son();
        mother mother = new mother();
        daugther daugther = new daugther();
        father.house();
        son.bike();son.house();
        mother.gold();
        daugther.house();daugther.bike();daugther.laptop();

    }
}