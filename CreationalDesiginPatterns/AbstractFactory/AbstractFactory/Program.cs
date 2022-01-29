//sea animals
interface animal
{
    public void speak();
}
class octopus:animal
{
    public void speak()
    {
        Console.WriteLine("Squawck");
    }
}
class sharp:animal
{
    public void speak()
    {
        Console.WriteLine("Can't speak");
    }
}
//land animals
class cat : animal
{
    public void speak()
    {
        Console.WriteLine("meow");
    }
}
class lion : animal
{
    public void speak()
    {
        Console.WriteLine("roar");
    }
}
abstract class abstract_factory
{
    public abstract animal GetAnimal(string name);
    public static abstract_factory createfactory(string factory)
    {
        if (factory == "sea")
            return new sea_factory();
        else if (factory =="land")
            return new land_factory();
        return null;
    }
}
class sea_factory: abstract_factory
{
    public override animal GetAnimal(string name)
    {
        if (name == "octopus")
            return new octopus();
        else if (name == "shark")
            return new sharp();
        return null;
    }
}
class land_factory: abstract_factory
{
    public override animal GetAnimal(string name)
    {
        if (name == "lion")
            return new lion();
        else if (name == "cat")
            return new cat();
        return null;
    }
}
class program
{
    static void Main()
    {
        abstract_factory obj = abstract_factory.createfactory("sea");
        abstract_factory obj2 = abstract_factory.createfactory("land");
        obj.GetAnimal("octopus").speak();
    }
}
