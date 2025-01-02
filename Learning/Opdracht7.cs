namespace Learning;

public class Opdracht7
{
    public static void Run()
    {
        var priemGetallen = new List<int>();
        
        priemGetallen.Add(2); //voeg het eerste priemgetal toe aan priemgetallen list.
        
        int i = 1; // nummer dat gechecket wordt of het een priemgetal is.
        
        while (priemGetallen.Count < 10) //hoeveel priemgetallen er uiteindelijk in de lijst moeten komen (nu 10)
        {
            i++;
            Boolean isPriem = true;
            //checket i deelbaar is door een priemgetal
            foreach (int priem in priemGetallen)
            {
                if (i % priem == 0) // als i deelbaar is door de priemgetal dan is variabel "i" geen priemgetal
                {
                    isPriem = false;
                    break;
                }
            }
            if (isPriem)
            {
                priemGetallen.Add(i);
            }
        }   
        // print de alle priemgetallen in priemgetallen lijst.
        Console.WriteLine(string.Join(", ",  priemGetallen));
    }
}