namespace FlorisVx;

public class Truck : Vehicle, IDriveable, IHasEngine, ICargo
{
    public Truck(ColorsVehicle colorTruck, string model, int year)
    {
        ColorVehicle = colorTruck;
        Model = model;
        Year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Truck Plane engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Truck engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} Truck on the ground");
    }

    public void LoadCargo()
    {
        Console.WriteLine($"Loading cargo in {ColorVehicle} Truck");
    }
}