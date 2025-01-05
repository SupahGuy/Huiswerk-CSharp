namespace FlorisVx;

public class Plane : Vehicle, IDriveable, IHasEngine, IFlyable
{
    public Plane(ColorsVehicle colorPlane, string model, int year)
    {
        ColorVehicle = colorPlane;
        Model = model;
        Year = year;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Plane engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Plane engine stopped");
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} on the ground");
    }

    public override void Fly()
    {
        Console.WriteLine($"Flying a {ColorVehicle} Plane");
    }
}