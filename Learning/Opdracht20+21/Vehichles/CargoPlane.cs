namespace FlorisVx;

public class CargoPlane : Vehicle, IDriveable, IHasEngine, IFlyable, ICargo
{
    public CargoPlane(ColorsVehicle colorCargoPlane, string model, int year)
    {
        ColorVehicle = colorCargoPlane;
        Model = model;
        Year = year;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Cargo Plane engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Cargo Plane engine stopped");
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} Cargo Plane on the ground");
    }

    public override void LoadCargo()
    {
        Console.WriteLine($"Loading cargo in {ColorVehicle} plane");
    }

    public override void Fly()
    {
        Console.WriteLine($"Flying a {ColorVehicle} cargo Plane");
    }
}