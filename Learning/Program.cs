using System;
using Learning.Opdracht19;
using System.Diagnostics;
using System.Threading;
namespace Learning
{
    class Program
    { 
        public async static Task Main(string[] args)
        // static Program()
        {
            // gebruik ctrl+/ om dit uit de comment te halen zo kan je makkelijk alles runnen.
            
            // Opdracht1.Run(6.9); // Cijfer naar voldoende, onvoldoende enz.. Switch variant
            // Opdracht2.Run(6.9); // Cijfer naar voldoende, onvoldoende enz.. If-Statement variant
            // Opdracht3.Run(); // Hoger of Lager spel
            // Opdracht4.Run(); // Do...While Loop  1 t/m 10
            // Opdracht5.Run(); // FizzBuzz For Loop 3,5
            // Opdracht6.Run(); // Foreach print namen <= 5 tekens.
            // Opdracht7.Run(); // Priemgetallen 10 break loop
            // Opdracht8.Run(); // continue wanneer i deelbaar is door 3
            // Opdracht9.Run(69); // invoer getal 1-100(natuurlijke getallen) print naar voldoende, onvoldoende enz.. // Short-if variant
            // Opdracht10.Run(); // Quiz met totaal score aan het einde.
            // Opdracht11.Run(); // Hoofdmenu om andere opdracht 1-10 te runnen.
            
            //Calculator.RunCalculator(); // Run de CleanCode Calculator app van Opdracht 16
            
            //Opdracht13.Run(); //FizzBuzzBang leuke opdracht
            
            //Opdracht14.Run(); // Fibonacci op verschillende manieren, eerste gebruik van Recursieve Algoritmes(cool maar lastig, heb zelf alles moeten onderzoeken) en Memoization.
            
            
            //Opdracht 17-1
            // Opdracht17_1 o17_1 = new Opdracht17_1();
            // o17_1.Run();
            
            //Opdracht 17_2
            // Opdracht17_2 o17_2 = new Opdracht17_2();
            // o17_2.Run();
            
            //Opdracht 17_3
            // Opdracht17_3 o17_3 = new Opdracht17_3();
            // o17_3.Run();
            
            //Opdracht 17_4
            // Opdracht17_4 o17_4 = new Opdracht17_4();
            // o17_4.Run();

            //Opdracht 17_5
            // Opdracht17_5 o17_5 = new Opdracht17_5();
            // o17_5.Run();

            //Opdracht 17_6
            // Opdracht17_6 o17_6 = new Opdracht17_6();
            // o17_6.Run();
            
            //Opdracht 17_7
            // Opdracht17_7 o17_7 = new Opdracht17_7();
            // o17_7.Run();
            
            //Opdracht 17_8
            // Opdracht17_8 o17_8 = new Opdracht17_8();
            // o17_8.Run();
            
            //Opdracht 18_1 en 18_2
            
            // Bicycle bicycle1 = new Bicycle(Bicycle.Sloten.WielSlot, Bicycle.Kleuren.Black, 13, Bicycle.FietsTypes.Elektrisch);
            // Console.WriteLine(bicycle1.ToString());
            // bicycle1.RangeInKm(10.5);
            // bicycle1.Lock();
            // Console.WriteLine(bicycle1.ToString());
            // bicycle1.Unlock();
            // Console.WriteLine(bicycle1.ToString());
            //
            // Bicycle bicycle2 = new Bicycle(Bicycle.Sloten.Sleutel, Bicycle.Kleuren.NeonBlue, 53, Bicycle.FietsTypes.Standaard);
            // bicycle2.Unlock();
            // bicycle2.RangeInMiles(25);
            // Console.WriteLine(bicycle2.ToString());
            //
            // Bicycle bicycle3 = new Bicycle(Bicycle.Sloten.DubbeleSlot, Bicycle.Kleuren.Camel, 3, Bicycle.FietsTypes.Elektrisch);
            // Console.WriteLine(bicycle3.ToString());
            // bicycle3.Lock();
            // bicycle3.RangeInMiles(15000);
            // Console.WriteLine(bicycle3.ToString());
            
            //Opdracht 18_3
            // Console.WriteLine(Calculator.Sub(3, -3.5));
            // Console.WriteLine(Calculator.Add(10.8, 15.2));
            
            //Opdracht18_4
            // Person p1 = new Person();
            // Console.WriteLine(p1.ToString());
            //
            // Person p2 = new Person();
            // Person p3 = new Person();
            //
            // Console.WriteLine(p2.ToString());
            // Console.WriteLine(p3.ToString());
            // Console.WriteLine(p2.ToString());
            
            //Opdracht18_5
            // Console.WriteLine(
            //     "applicatie naam:" +
            //     ConfigurationData.Get_applicatieNaam() +
            //         "\nversie:" +
            // ConfigurationData.Get_versie() +
            //         "\nmax gebruikers:" +
            // ConfigurationData.Get_maxAantalGebruikers());

            //Opdracht 19_1
            // Car c1 = new Car(Car.Brand.Hyundai, Car.TypeCar.Minitruck, Car.Color.Red, 2000, 12419424120);
            // c1.DisplayInfo();
            // Car c2 = new Car(Car.Brand.Lamborghini, Car.TypeCar.Minitruck, Car.Color.Green, 2077, 0000000000001);
            // c2.DisplayInfo();
            
            //Opdracht 19_2
            // Garage g1 = new Garage();
            // g1.AddCar(Car.Brand.Hyundai, Car.TypeCar.Minitruck, Car.Color.Red, 2000, 12419424120);
            // g1.DisplayInfo();
            //
            // g1.AddCar(Car.Brand.Lamborghini, Car.TypeCar.Minitruck, Car.Color.Green, 2077, 0000000000001);
            //
            // g1.AddCar(Car.Brand.BMW, Car.TypeCar.SUV, Car.Color.Black, 2020, 931049104285);
            //
            // g1.DisplayInfo();
            
            //Opdracht 19_3
            // WPark w1 = new WPark();
            // w1.AddGarage("WparkGarage1");
            // w1.AddGarage("WparkGarage2");
            // w1.AddCar("WparkGarage1", Car.TypeCar.Hatchback, Car.Brand.Lamborghini, Car.Color.Black, 2000, 190149104202);
            // w1.AddCar("WparkGarage2", Car.TypeCar.SUV, Car.Brand.BMW, Car.Color.Blue, 1930, 0000000000000000);
            // w1.AddCar("WparkGarage2", Car.TypeCar.Minitruck, Car.Brand.Hyundai, Car.Color.Red, 2025, 928561946201);
            // w1.AddGarage("WparkBackupGarage");
            // w1.DisplayList();
            
            
            //Opdracht 16 (Digischool)
            // var users = new List<Opdracht16__digischool_.User>
            // {
            //     new Opdracht16__digischool_.Teacher("Mr. Crack", 1001, 101, 20),
            //     new Opdracht16__digischool_.Student("Joél Gravendörf", 2001, 301, 2),
            //     new Opdracht16__digischool_.Student("Jesus", 2002, 302, 3)
            // };
            //
            // var materials = new List<Opdracht16__digischool_.Material>
            // {
            //     new Opdracht16__digischool_.Book("Book", "A hitchhikers guide of the galaxy", "Hitchhiking across the galaxy", "Sci-Fi", "Peter Pannekoek"),
            //     new Opdracht16__digischool_.DigitalDocument("DigitalDocument", "SOAD album", "Mesmerize", "mp3", 120),
            //     new Opdracht16__digischool_.Video("Video", "C# Tutorial", "Comprehensive C# video guide", 7200, true)
            // };
            //
            // var courses = new List<Opdracht16__digischool_.Course>
            // {
            //     new Opdracht16__digischool_.Course(1, "C# ", "deze vak"),
            //     new Opdracht16__digischool_.Course(2, "Operations", "Dit is operations met devops enzo")
            // };
            //
            // // Display data
            // Console.WriteLine("\nUsers:");
            // foreach (var user in users)
            // {
            //     Console.WriteLine("\n" +user);
            // }
            //
            // Console.WriteLine("\nMaterials:");
            // foreach (var material in materials)
            // {
            //     Console.WriteLine("\n" +material);
            // }
            //
            // Console.WriteLine("\nCourses:");
            // foreach (var course in courses)
            // {
            //     Console.WriteLine("\n" + course);
            // }
            
            //Opdracht 20+21 (zie Folder Opdracht 20+21.) in Program moet je main uitcommenten.
            
            //Opdracht 22
            
            //Zonder Async
            // Opdracht22 o22 = new Opdracht22();
            // Stopwatch stopWatch1 = new Stopwatch();
            //
            // stopWatch1.Start();
            // o22.NewList();
            // o22.GetDataFromCsv();
            //
            // o22.NewList();
            // o22.GetDataFromCsv();
            //
            // o22.NewList();
            // o22.GetDataFromCsv();
            //
            // o22.NewList();
            // o22.GetDataFromCsv();
            //
            // o22.NewList();
            // o22.GetDataFromCsv();
            //
            // o22.CalculateCount();
            //
            // stopWatch1.Stop();
            // TimeSpan ts1 = stopWatch1.Elapsed;
            //
            // Console.WriteLine("Time zonder async:" + ts1);
            //
            // //met async
            //
            // Opdracht22Async o22async = new Opdracht22Async();
            // Stopwatch stopWatch2 = new Stopwatch();
            //
            // stopWatch2.Start();
            //
            // o22async.GetSumOfAllFiles(5);
            // o22async.CalculateCount();
            //
            // stopWatch2.Stop();
            // TimeSpan ts2 = stopWatch2.Elapsed;
            //
            // Console.WriteLine("Time met async:" + ts2);
            //
            // //gemideld is de tijd met async ongeveer 2x sneller met mijn code.
            // //het gebruikt nu alleen async om alle variablen in een list<string> te zetten.
            // //ik zie nu dat ik ook gewoon gelijk van de reader naar een nummer kan veranderen en dan dat bij elkaar optellen maar nu is het dezelfde code maar sneller.
            // //het doet dit door meerdere instances van een bepaalde methode of "task" te doen tegelijkertijd.
            // //ik begrijp nu de basis van Async en Await. 


        }
    }
}