namespace FlorisVx;

public class Vehicle
{
    public enum ColorsVehicle
    {
        Red,
        Yellow,
        Blue
    }
    
    public string Model { get; set; }
    public int Year { get; set; }
    public ColorsVehicle ColorVehicle { get; set; }

    public virtual void Drive() => Console.WriteLine("Driving Vehicle");
    public virtual void StartEngine() => Console.WriteLine("Staring engine of Vehicle");
    public virtual void StopEngine() => Console.WriteLine("Stopping engine of Vehicle");
    public virtual void Fly() => Console.WriteLine("Flying Vehicle");
    public virtual void LoadCargo() => Console.WriteLine("Loading Cargo on Vehicle");
}