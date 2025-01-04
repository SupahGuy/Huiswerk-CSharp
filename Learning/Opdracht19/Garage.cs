namespace Learning.Opdracht19;
public class Garage
{
    private List<Car> _CarList { get; set; }

    //used to initialize _CarList
    public Garage()
    {
        _CarList = new List<Car>();
    }

    //Adds car to _CarList so it can be used to Displayinfo and remove later.
    public void AddCar(Car.Brand brand, Car.TypeCar typeCar, Car.Color color, int year, long vin)
    {
        Car tempCar = new Car(brand, typeCar, color, year, vin);
        _CarList.Add(tempCar);
    }

    //removes car based on input index 0 = first car
    public void RemoveCar(int removeIndex)
    {
        _CarList.RemoveAt(removeIndex);
        
    }

    //displays all info from the Car Class.
    public void DisplayInfo()
    {
        Console.WriteLine("#########");
        foreach (Car car in _CarList)
        {
            car.DisplayInfo();
        }
    }
}