namespace Learning.Opdracht19;

public class Car
{
    public enum Brand
    {
        Hyundai,
        Lamborghini,
        BMW,
        Lexus,
        KIA,
    }

    public enum TypeCar
    {
        SUV,
        Stationwagen,
        Sedan,
        Hatchback,
        Minitruck
    }

    public enum Color
    {
        Blue,
        Red,
        Green,
        Black,
        White,
        Yellow,
    }

    private int _Year { get; set;}

    private long _Vin { get; set; }
    private Color _Color { get; set; }
    private Brand _Brand { get; set; }
    private TypeCar _TypeCar { get; set; }

    //Constructs car
    public Car(Brand brand, TypeCar typeCar, Color color, int year, long vin)
    {
        _Brand = brand;
        _TypeCar = typeCar;
        _Color = color;
        _Year = year;
        _Vin = vin;
    }
    
    //CW'd all known info.
    public void DisplayInfo()
    {
        Console.WriteLine($"\nBrand: {_Brand}\nType: {_TypeCar}\nColor {_Color}\nYear: {_Year}\nVin: {_Vin}");
    }
}