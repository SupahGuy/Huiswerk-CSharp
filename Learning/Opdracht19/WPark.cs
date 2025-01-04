namespace Learning.Opdracht19;

public class WPark
{
    private Dictionary<string, Garage> _GarageList;

    public WPark()
    {
        _GarageList = new Dictionary<string, Garage>();
    }

    public void AddGarage(string tempGarageNaam)
    {
        Garage tempGarage = new Garage();
        _GarageList.Add(tempGarageNaam, tempGarage);
    }

    public void RemoveGarage(string GarageNaam)
    {
        _GarageList.Remove(GarageNaam);
    }

    public void AddCar(string garageNaam, Car.TypeCar typeCar, Car.Brand brand, Car.Color color, int year, long vin)
    {
        _GarageList[garageNaam].AddCar(brand, typeCar, color, year, vin);
    }

    public void RemoveCar(string garageNaam, int carIndex)
    {
        _GarageList[garageNaam].RemoveCar(carIndex);
    }

    public void DisplayList()
    {
        foreach (KeyValuePair<string, Garage> garage in _GarageList)
        {
            Console.WriteLine("Garage: " + garage.Key);
            garage.Value.DisplayInfo();
        }
        
    }
}