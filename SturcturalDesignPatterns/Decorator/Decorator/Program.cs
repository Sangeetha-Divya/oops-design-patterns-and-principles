public abstract class Shape
{
    public abstract void draw();
}
public class rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("Rectangle");
    }
}
public abstract class Decorator : Shape
{
    protected Shape component;
    public void SetComponent(Shape component)
    {
        this.component = component;
    }
    public override void draw()
    {
        if (component != null)
        {
            component.draw();
        }
    }
}
public class Circle : Decorator
{
    public override void draw()
    {
        base.draw();
        Console.WriteLine("Circle");
    }
}
public class rhombus : Decorator
{
    public override void draw()
    {
        base.draw();
        Console.WriteLine("rhombus");
    }
}
public class Program
{
    public static void Main(string[] args)
     {
            rectangle c = new rectangle();
            Circle d1 = new Circle();
            rhombus d2 = new rhombus();
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.draw();
     }
}