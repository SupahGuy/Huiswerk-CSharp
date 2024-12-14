namespace Learning;

public class Opdracht5
{
    public static void Run()
    {
        // print fizz of buzz of fizzbuzz als het getal deelbaar is door 3, 5 of 3(5)
        
        for (int i = 0; i < 101; i++)
        {
            //dit is de string die fizz of buzz / fizzbuzz print als het deel getal i deelbaar is door 3
            String fizzBuzz = "";

            if (checkDeelbaar(3, i))
            {
                fizzBuzz += "Fizz";
            }
            if (checkDeelbaar(5, i))
            {
                fizzBuzz += "Buzz";
            }

            if (fizzBuzz == "")
            {
                Console.WriteLine(i);
            }
            else
            {
                System.Console.WriteLine(fizzBuzz);
            }
            

        }
        
        
    }
    
    
    //checket of het huidigGetal deelbaar is door een bepaald ander getal (alleen natuurlijke getallen)
    public static bool checkDeelbaar(decimal deelbaarGetal, decimal huidigGetal)
    {
        Boolean isdeelbaar = ((huidigGetal / deelbaarGetal) == Math.Round((huidigGetal / deelbaarGetal))); // 

        return isdeelbaar;
    }
     
}