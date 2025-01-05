namespace FlorisVx;

public class CargoPlane : Vehicle, IDriveable, IHasEngine, IFlyable, ICargo
{
    public CargoPlane(ColorsVehicle colorCargoPlane, string model, int year)
    {
        ColorVehicle = colorCargoPlane;
        Model = model;
        Year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Cargo Plane engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Cargo Plane engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} Cargo Plane on the ground");
    }

    public void LoadCargo()
    {
        Console.WriteLine($"Loading cargo in {ColorVehicle} plane");
    }

    public void Fly()
    {
        Console.WriteLine($"Flying a {ColorVehicle} cargo Plane");
    }
}