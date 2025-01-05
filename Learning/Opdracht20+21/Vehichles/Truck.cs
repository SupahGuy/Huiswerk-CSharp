namespace FlorisVx;

public class Truck : Vehicle, IDriveable, IHasEngine, ICargo
{
    public Truck(ColorsVehicle colorTruck, string model, int year)
    {
        ColorVehicle = colorTruck;
        Model = model;
        Year = year;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Truck engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Truck engine stopped");
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} Truck");
    }

    public override void LoadCargo()
    {
        Console.WriteLine($"Loading cargo in {ColorVehicle} Truck");
    }
}