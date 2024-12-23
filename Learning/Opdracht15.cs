using System.Collections;

namespace Learning;

public class Opdracht15
{
    //Dictionary voor Memoization Algoritme.
    private static Dictionary<long, long> memoizationNummers;
    
    public static void Run()
    {
        
        Console.WriteLine("Welke manier van fibonacci sequentie berekenen wilt u?");
        Console.WriteLine("1 = Iteratief");
        Console.WriteLine("2 = Recursief");
        Console.WriteLine("3 = Memoization Recursief");
        
        int methodeFibonacci = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Hoeveel iteraties aan fibonacci series wilt u uitvoeren? (80+ niet aangeraden) v.w. overflow ");
        int inputGebruiker = Convert.ToInt32(Console.ReadLine());
        
        switch (methodeFibonacci)
        {
            //iteratief
            case 1:
                    FibonacciIteratief(inputGebruiker);
                break;
            
            //recursief
            case 2:
                //print in de for loop zodat het alleen het eind resultaat laat zien en niet de stappen daarintussen.
                for (int i = 0; i < inputGebruiker; i++)
                {
                    Console.WriteLine(FibonacciRecursief(i));
                }
                break;
            
            //recursief memoization
            case 3:
                for (int i = 0; i < inputGebruiker; i++)
                {
                    Console.WriteLine(fibonacciMemoization(i));
                }
                break;
            
            //bij onverwachte input
            default:
                Console.WriteLine("Error.");
                break;
            
        }
    }



    public static void FibonacciIteratief(int aantalIteraties)
    {
        //start nummers
        long number1 = 1;
        long number2 = 0;
        
        for (int i = 0; aantalIteraties > i; i++)
        {
            number1 += number2;
            (number1, number2) = (number2, number1); // switchet number1 naar number2 en vice versa
            
            System.Console.WriteLine(number1);
        }
    }

    public static long FibonacciRecursief(long i)
    {
        //start nummers
        if (i == 0) return 0;
        if (i == 1) return 1;
        
        //Roept zichzelf aan om de 2 voorafgaande nummers (i-1 en i-2) te berekenen, dit doet het totdat het alle voorafgaande fibonacci nummers heeft berekend.
        //na dit is gedaan return het "nummer" van deze proces. oftewel de 2 nummers voor deze nummer bij elkaar.
        long nummer = FibonacciRecursief(i - 1) + FibonacciRecursief(i - 2);
        return nummer;
    }

    public static long fibonacciMemoization(long i)
    {
        //start nummers
        if (i == 0) return 0;
        if (i == 1) return 1;

        //checket of de i(key) dus bijv i = 10 = memoizationNummers[10] = 34.
        //dit is de "shortcut" i.v.m. normaal recursief.
        
        if (memoizationNummers.ContainsKey(i))
        {
            return memoizationNummers[i];
        }
        
        //Maakt de functie Recursief doordat het zichzelf aanroept, en haalt de 2 getallen die hiervoor waren op. 
        //ex. bij i=5 checket het i=3 en i=2 want de key van i=5 = i=4 + i=3(de 2 getallen daarvoor)
        long nummer = fibonacciMemoization(i - 1) + fibonacciMemoization(i - 2);
        
        //voegt niet geïndexeerde nummers toe aan de Dictionary memoizationNummers.
        memoizationNummers[i] = nummer;
        return nummer;
    }
}