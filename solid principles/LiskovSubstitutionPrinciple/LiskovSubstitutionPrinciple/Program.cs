public abstract class Shape
{
    public abstract string GetShape();
}

public class Triangle : Shape
{
    public override string GetShape()
    {
        return "Triangle";
    }
}

public class Circle : Triangle
{
    public override string GetShape()
    {
        return "Circle";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Circle();
        Console.WriteLine(shape.GetShape());
        shape = new Triangle();
        Console.WriteLine(shape.GetShape());
    }
}
