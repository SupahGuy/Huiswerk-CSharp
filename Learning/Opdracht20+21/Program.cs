using System;
//Ik vond deze opdracht wel leuk om te doen, niet te moeilijk niet te makkelijk enigste is wel dat het repetetief is.
namespace FlorisVx
{
    class Program
    {
        // static void Main(string[] args)  // om de programma te laten werken Remove je de comment op deze line en verwijder je de volgende lijn
        static Program() //(remove deze line)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            //ik neem aan dat dit motorfietsen zijn. dus ook engines hebben.
            Bike redBike = new Bike(Vehicle.ColorsVehicle.Red, "Old", 2000);
            vehicleList.Add(redBike);
            
            Bike yellowBike = new Bike(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            vehicleList.Add(yellowBike);

            Bike blueBike = new Bike(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            vehicleList.Add(blueBike);

            Car redCar = new Car(Vehicle.ColorsVehicle.Red, "Old", 2000);
            vehicleList.Add(redCar);

            Car yellowCar = new Car(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            vehicleList.Add(yellowCar);

            Car blueCar = new Car(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            vehicleList.Add(blueCar);

            Truck redTruck = new Truck(Vehicle.ColorsVehicle.Red, "Old", 2000);
            vehicleList.Add(redTruck);

            Truck yellowTruck = new Truck(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            vehicleList.Add(yellowTruck);

            Truck blueTruck = new Truck(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            vehicleList.Add(blueTruck);

            Plane redPlane = new Plane(Vehicle.ColorsVehicle.Red, "Old", 2000);
            vehicleList.Add(redPlane);

            Plane yellowPlane = new Plane(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            vehicleList.Add(yellowPlane);

            Plane bluePlane = new Plane(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            vehicleList.Add(bluePlane);

            CargoPlane redCargoPlane = new CargoPlane(Vehicle.ColorsVehicle.Red, "Old", 2000);
            vehicleList.Add(redCargoPlane);

            CargoPlane yellowCargoPlane = new CargoPlane(Vehicle.ColorsVehicle.Yellow, "MidSize", 2015);
            vehicleList.Add(yellowCargoPlane);

            CargoPlane blueCargoPlane = new CargoPlane(Vehicle.ColorsVehicle.Blue, "GOLiATH", 2100);
            vehicleList.Add(blueCargoPlane);

            foreach (var vehicle in vehicleList)
            {
                if (vehicle is Bike)
                {
                    vehicle.StartEngine();
                    vehicle.Drive();
                    vehicle.StopEngine();
                }

                if (vehicle is Car)
                {
                    vehicle.StartEngine();
                    vehicle.Drive();
                    vehicle.StopEngine();

                }
                
                if (vehicle is CargoPlane)
                {
                    vehicle.StartEngine();
                    vehicle.Drive();
                    vehicle.Fly();
                    vehicle.LoadCargo();
                    vehicle.StopEngine();
                }
                
                if (vehicle is Plane)
                {
                    vehicle.StartEngine();
                    vehicle.Drive();
                    vehicle.Fly();
                    vehicle.StopEngine();
                }
                
                if (vehicle is Truck)
                {
                    vehicle.StartEngine();
                    vehicle.Drive();
                    vehicle.LoadCargo();
                    vehicle.StopEngine();
                }
                Console.WriteLine(""); // spacing tussen elke vehicle dat geprint wordt.
            }
        }
    }
}