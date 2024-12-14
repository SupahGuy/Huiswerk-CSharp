namespace Learning;

public class Opdracht2
{
    
    public static void Run(double UserInputNumber)
    {

        //doet de askUserNumberAndReturnIt nummer in de ConvertandPrintUserInputNumber
        convertAndPrintUserInputNumber(UserInputNumber);


    }
    
    // Converteert een invoer nummer naar een slecht, matig, voldoende, goed, en uitstekend en print dit.
    public static void convertAndPrintUserInputNumber(double userInputNumber)
    {
        if (userInputNumber >= 1 && userInputNumber < 4)
        {
            System.Console.WriteLine("Slecht");
        }
        else if (userInputNumber >= 4 && userInputNumber < 5.5)
        {
            System.Console.WriteLine("Matig");
        }
        else if (userInputNumber >= 5.5 && userInputNumber < 7.0)
        {
            System.Console.WriteLine("Voldoende");
        }
        else if (userInputNumber >= 7.0 && userInputNumber < 8.5)
        {
            System.Console.WriteLine("Goed");
        } 
        else if (userInputNumber >= 8.5 && userInputNumber < 10)
        {
            System.Console.WriteLine("Uitstekend");
        }
        else
        {
            System.Console.WriteLine("Error: Nummer te groot of te Klein.");
        }
        
    }
}