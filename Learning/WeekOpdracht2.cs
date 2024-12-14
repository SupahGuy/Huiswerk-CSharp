using System.Collections;

namespace Learning;

public class WeekOpdracht2
{
    public static void Opdracht13en14()
    {
        //getal dat wordt geprint als het getal niet deelbaar is door 3,5, of 7.
        int huidigGetal = 1;
        
        //output als het deelbaar is door 3 of 5 of 7
        string outputFizzBuzz = "";
        
        Console.WriteLine("tot hoeveel moet dit algoritme gaan?");
        int maxGetalUserInput = Convert.ToInt32(Console.ReadLine());

        
        //FizzBuzz algoritme 
        do
        {
            //reset de output voor de String
            outputFizzBuzz = "";   
            
            //voegt Fizz, Buzz, of Bang toe aan een String dependent of het deelbaar is door 3,5 en/of 7.
            if (checkDeelbaar(3, huidigGetal))
            {
                outputFizzBuzz = outputFizzBuzz + "Fizz";
            }
            if (checkDeelbaar(5, huidigGetal))
            {
                outputFizzBuzz = outputFizzBuzz + "Buzz";
            }
            if (checkDeelbaar(7, huidigGetal))
            {
                outputFizzBuzz = outputFizzBuzz + "Bang";
            }
            
            
            //als het niet deelbaar is door 3 of 5 dan print het de nummer anders output van fizzbuzz
            if (outputFizzBuzz == "")
            {
                Console.WriteLine(huidigGetal);
            }
            else
            {
                Console.WriteLine(outputFizzBuzz);        
            }
            
            huidigGetal++;
        }while(huidigGetal < maxGetalUserInput);
    }
    
    
    //checket of het huidigGetal deelbaar is door een bepaald ander getal (alleen natuurlijke getallen)
    public static bool checkDeelbaar(decimal deelbaarGetal, decimal huidigGetal)
    {
        Boolean isdeelbaar = ((huidigGetal / deelbaarGetal) == Math.Round((huidigGetal / deelbaarGetal))); // 

        return isdeelbaar;
    }



    public static void Opdracht15()
    {
        iteratieveFibonacci(1000);
    }
    
    public static void iteratieveFibonacci(int repetities)
    {
        int a = 1;
        int b = 2;

        for (int i = 0; i < repetities; i++)
        {
            Console.WriteLine(a); 

            a += b; // Dit betekent: a + a = b
            (a,b) = (b,a); // Swapped de variabel b naar a EN a naar b.


        }
    }
}