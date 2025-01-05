namespace Learning.Opdracht19;

public class WPark
{
    private Dictionary<string, Garage> _garageList;

    public WPark()
    {
        _garageList = new Dictionary<string, Garage>();
    }

    public void AddGarage(string tempGarageNaam)
    {
        Garage tempGarage = new Garage();
        _garageList.Add(tempGarageNaam, tempGarage);
    }

    public void RemoveGarage(string GarageNaam)
    {
        _garageList.Remove(GarageNaam);
    }

    public void AddCar(string garageNaam, Car.TypeCar typeCar, Car.Brand brand, Car.Color color, int year, long vin)
    {
        _garageList[garageNaam].AddCar(brand, typeCar, color, year, vin);
    }

    public void RemoveCar(string garageNaam, int carIndex)
    {
        _garageList[garageNaam].RemoveCar(carIndex);
    }

    public void DisplayList()
    {
        foreach (KeyValuePair<string, Garage> garage in _garageList)
        {
            Console.WriteLine("Garage: " + garage.Key);
            garage.Value.DisplayInfo();
        }
    }
}