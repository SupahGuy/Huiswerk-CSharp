namespace FlorisVx;

public class Car : Vehicle, IHasEngine, IDriveable
{
    public Car(ColorsVehicle colorCar, string model, int year)
    {
        ColorVehicle = colorCar;
        Model = model;
        Year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine($"{ColorVehicle} Car engine started");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{ColorVehicle} Car engine stopped");
    }

    public void Drive()
    {
        Console.WriteLine($"Driving a {ColorVehicle} Car");
    }
}