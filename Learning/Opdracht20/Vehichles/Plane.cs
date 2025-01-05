namespace FlorisVx;

public class Plane : Vehicle, IDriveable, IHasEngine, IFlyable
{
    public Plane(ColorsVehicle colorPlane, string model, int year)
    {
        ColorVehicle = colorPlane;
        Model = model;
        Year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Plane engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Plane engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} on the ground");
    }

    public void Fly()
    {
        Console.WriteLine($"Flying a {ColorVehicle} Plane");
    }
}