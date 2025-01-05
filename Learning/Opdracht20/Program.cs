using System;
//Ik vond deze opdracht wel leuk om te doen, niet te moeilijk niet te makkelijk enigste is wel dat het repetetief is.
namespace FlorisVx
{
    class Program
    {
        static void Main(string[] args)  // om de programma te laten werken Remove je de comment op deze line en verwijder je de volgende lijn
        // static Program() //(remove deze line)
        {
            //ik neem aan dat dit motorfietsen zijn. dus ook engines hebben.
            Bike redBike = new Bike(Vehicle.ColorsVehicle.Red, "Old", 2000);
            redBike.StartEngine();
            redBike.Drive();
            redBike.StopEngine();

            Bike yellowBike = new Bike(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            yellowBike.StartEngine();
            yellowBike.Drive();
            yellowBike.StopEngine();

            Bike blueBike = new Bike(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            blueBike.StartEngine();
            blueBike.Drive();
            blueBike.StopEngine();

            Car redCar = new Car(Vehicle.ColorsVehicle.Red, "Old", 2000);
            redCar.StartEngine();
            redCar.Drive();
            redCar.StopEngine();

            Car yellowCar = new Car(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            yellowCar.StartEngine();
            yellowCar.Drive();
            yellowCar.StopEngine();

            Car blueCar = new Car(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            blueCar.StartEngine();
            blueCar.Drive();
            blueCar.StopEngine();

            Truck redTruck = new Truck(Vehicle.ColorsVehicle.Red, "Old", 2000);
            redTruck.StartEngine();
            redTruck.Drive();
            redTruck.LoadCargo();
            redTruck.StopEngine();

            Truck yellowTruck = new Truck(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            yellowTruck.StartEngine();
            yellowTruck.Drive();
            yellowTruck.LoadCargo();
            yellowTruck.StopEngine();

            Truck blueTruck = new Truck(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            blueTruck.StartEngine();
            blueTruck.Drive();
            blueTruck.LoadCargo();
            blueTruck.StopEngine();

            Plane redPlane = new Plane(Vehicle.ColorsVehicle.Red, "Old", 2000);
            redPlane.StartEngine();
            redPlane.Drive();
            redPlane.Fly();
            redPlane.StopEngine();

            Plane yellowPlane = new Plane(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            yellowPlane.StartEngine();
            yellowPlane.Drive();
            yellowPlane.Fly();
            yellowPlane.StopEngine();

            Plane bluePlane = new Plane(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            bluePlane.StartEngine();
            bluePlane.Drive();
            bluePlane.Fly();
            bluePlane.StopEngine();

            CargoPlane redCargoPlane = new CargoPlane(Vehicle.ColorsVehicle.Red, "Old", 2000);
            redCargoPlane.StartEngine();
            redCargoPlane.Drive();
            redCargoPlane.Fly();
            redCargoPlane.LoadCargo();
            redCargoPlane.StopEngine();

            CargoPlane yellowCargoPlane = new CargoPlane(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            yellowCargoPlane.StartEngine();
            yellowCargoPlane.Drive();
            yellowCargoPlane.Fly();
            yellowCargoPlane.LoadCargo();
            yellowCargoPlane.StopEngine();

            CargoPlane blueCargoPlane = new CargoPlane(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            blueCargoPlane.StartEngine();
            blueCargoPlane.Drive();
            blueCargoPlane.Fly();
            blueCargoPlane.LoadCargo();
            blueCargoPlane.StopEngine();
        }
    }
}