namespace FlorisVx;

public class Bike : Vehicle, IDriveable, IHasEngine
{
    public Bike(ColorsVehicle colorBike, string model, int year)
    {
        ColorVehicle = colorBike;
        Model = model;
        Year = year;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Bike engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Bike engine stopped");
    }
    
    public override void Drive()
    {
        Console.WriteLine($"Riding a {ColorVehicle} Bike");
    }
}