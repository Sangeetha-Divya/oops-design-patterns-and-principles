public interface IVehicleBuilder
{
    void SetModel();
    void SetEngine();
    Vehicle GetVehicle();
}
public class HeroBuilder : IVehicleBuilder
{
    Vehicle objVehicle = new Vehicle();
    public void SetModel()
    {
        objVehicle.Model = "Hero";
    }

    public void SetEngine()
    {
        objVehicle.Engine = "4 Stroke";
    }
    public Vehicle GetVehicle()
    {
        return objVehicle;
    }
}
public class HondaBuilder : IVehicleBuilder
{
    Vehicle objVehicle = new Vehicle();
    public void SetModel()
    {
        objVehicle.Model = "Honda";
    }

    public void SetEngine()
    {
        objVehicle.Engine = "4 Stroke";
    }
    public Vehicle GetVehicle()
    {
        return objVehicle;
    }
}
public class Vehicle
{
    public string Model { get; set; }
    public string Engine { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine("Model: {0}", Model);
        Console.WriteLine("Engine: {0}", Engine);
    }
}
public class VehicleCreator
{
    private readonly IVehicleBuilder objBuilder;

    public VehicleCreator(IVehicleBuilder builder)
    {
        objBuilder = builder;
    }

    public void CreateVehicle()
    {
        objBuilder.SetModel();
        objBuilder.SetEngine();
    }

    public Vehicle GetVehicle()
    {
        return objBuilder.GetVehicle();
    }
}
class Program
{
    static void Main(string[] args)
    {
        var vehicleCreator = new VehicleCreator(new HeroBuilder());
        vehicleCreator.CreateVehicle();
        var vehicle = vehicleCreator.GetVehicle();
        vehicle.ShowInfo();
        vehicleCreator = new VehicleCreator(new HondaBuilder());
        vehicleCreator.CreateVehicle();
        vehicle = vehicleCreator.GetVehicle();
        vehicle.ShowInfo();
    }
}