namespace Learning;

public class Opdracht4
{
    public static void Run()
    {
        // Vraagt om een getal en als het tussen 1 t/m 10 ligt. vraagt het opnieuw om het te confirmen. Daarna print het het getal.
        
        do
        {
            Console.WriteLine("Voer een getal tussen 1 t/m 10 in.");
            try
            {
                var userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput >= 1 && userInput <= 10)
                {
                    Console.WriteLine("Weet je zeker dat je getal " + userInput + " wilt gebruiken? (Y/N)");
                }
                else
                {
                    Console.WriteLine("Voer een geldig getal in.");
                    continue; //Loopt het zodat een nieuw getal ingevoerd kan worden
                }
                
                var userInputYN = Convert.ToString(Console.ReadLine()); // als er geen Y wordt ingeput dan loopt het opnieuw.
                if (userInputYN == "Y" || userInputYN == "y")
                {
                    Console.WriteLine("Het getal " + userInput + " is gesavet"); //Het getal is niet gesavet
                    break; // Stopt de Loop
                }
                
            }
            //pakt errors en vraagt om een geldig getal in te voeren (blijft loopen)
            catch (Exception e)
            {
                Console.WriteLine("Voer een geldig getal in.");   
            }
        } 
        while(true);


        
        
    }    
}