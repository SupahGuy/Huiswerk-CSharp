namespace FlorisVx;

public class Bike : Vehicle, IDriveable, IHasEngine
{
    public Bike(ColorsVehicle colorBike, string model, int year)
    {
        ColorVehicle = colorBike;
        Model = model;
        Year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Bike engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Bike engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine($"Riding a {ColorVehicle} Bike");
    }
}