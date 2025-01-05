namespace FlorisVx;

public class Car : Vehicle, IHasEngine, IDriveable
{
    public Car(ColorsVehicle colorCar, string model, int year)
    {
        ColorVehicle = colorCar;
        Model = model;
        Year = year;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Car engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Car engine stopped");
    }

    public override void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} Car");
    }
}