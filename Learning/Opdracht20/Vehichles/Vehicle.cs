namespace FlorisVx;

public abstract class Vehicle
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
}