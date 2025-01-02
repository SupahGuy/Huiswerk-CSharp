namespace Learning;

public class Opdracht1
{
    public static void Run(double userInputNumber)
    {
        //print het resultaat van de convertNumberToGradeSwitch
        System.Console.WriteLine(ConvertNumberToGradeSwitch(userInputNumber));
    }
   
   
    // converteert de ingevulde nummer naar slecht, matig, voldoende, goed of uitstekend.
    static String ConvertNumberToGradeSwitch(Double userInputNumber)
    {
        switch (userInputNumber)
        {
            case >= 1 and <= 4:
                return "Slecht";
            case > 4 and <= 6:
                return "Matig";
            case > 6 and <= 7:
                return "Voldoende";
            case > 7 and <= 9:
                return "Goed";
            case >9 and <= 10:
                return "Uitstekend!";
        }
        return "Er is een fout opgetreden.";
    }


}