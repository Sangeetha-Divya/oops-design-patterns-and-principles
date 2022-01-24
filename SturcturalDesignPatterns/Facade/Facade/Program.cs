using System;
public class Program
{
        public static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();
            Console.ReadKey();
        }
}
public class SubSystemOne
{
        public void MethodOne()
        {
            Console.WriteLine(" SubSystemOne Method");
        }
}
public class SubSystemTwo
{
        public void MethodTwo()
        {
            Console.WriteLine(" SubSystemTwo Method");
        }
}
public class Facade
{
        SubSystemOne one;
        SubSystemTwo two;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            one.MethodOne();
            two.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            two.MethodTwo();
        }
}
