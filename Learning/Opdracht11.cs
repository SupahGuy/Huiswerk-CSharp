namespace Learning;

public class Opdracht11
{
    public static void Run()
    { 
        Hoofdmenu(); // om de eerste keer te laten runnen
    }

    public static void Hoofdmenu()
    {
        try
        {
            
        Console.WriteLine("\nHoofdmenu");
        Console.WriteLine("............................");
        Console.WriteLine("Toets 1 t/m 10 in om naar die opdracht te gaan.");
        Console.WriteLine("Toets '0' in om af te sluiten.");
        int inputGebruiker = Convert.ToInt32(Console.ReadLine());
        
        //Runnet opdracht 1 als gebruiker 1 input
        
        if (inputGebruiker == 1)
        {
            Console.WriteLine("Deze opdracht heeft een cijfer nodig van 1 t/m 10. (decimalen kan)");
            double i = Convert.ToDouble(Console.ReadLine());
            Opdracht1.Run(i);
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 2)
        {
            Console.WriteLine("Deze opdracht heeft een cijfer nodig van 1 t/m 10. (decimalen kan)");
            double i = Convert.ToDouble(Console.ReadLine());
            Opdracht2.Run(i);
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 3)
        {
            Opdracht3.Run();
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 4)
        {
            Opdracht4.Run();
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 5)
        {
            Opdracht5.Run();
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 6)
        {
            Opdracht6.Run();
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 7)
        {
            Opdracht7.Run();
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 8)
        {
            Opdracht8.Run();
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 9)
        {
            Console.WriteLine("Deze opdracht heeft een cijfer nodig van 1 t/m 100.");
            int i = Convert.ToInt32(Console.ReadLine());
            Opdracht9.Run(i);
            terugNaarHoofdmenu();
        }
        if (inputGebruiker == 10)
        {
            Opdracht10.Run();
            terugNaarHoofdmenu();
        }
        
        //Probeert het programma opnieuw als er een fout is.
        }
        catch (Exception e)
        {
            Console.WriteLine("er is een fout opgetreden... ");
            Hoofdmenu();
        }
    }

    static void terugNaarHoofdmenu()
    {
        Console.WriteLine("\nToets een knop in om terug te gaan naar het hoofdmenu....");
        Console.ReadKey();
        Hoofdmenu();
    }

}