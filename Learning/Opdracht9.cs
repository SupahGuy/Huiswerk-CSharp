namespace Learning;

public class Opdracht9
{
    public static void Run(int inputNumber)
    {
        if (inputNumber >=0 && inputNumber <= 49) Console.WriteLine("Onvoldoende");
        if (inputNumber >=50 && inputNumber <= 59) Console.WriteLine("Matig");
        if (inputNumber >=75 && inputNumber <= 89) Console.WriteLine("Voldoende");
        if (inputNumber >=60 && inputNumber <= 74) Console.WriteLine("Goed");
        if (inputNumber >=90 && inputNumber <= 100) Console.WriteLine("Uitstekend");
    }
}