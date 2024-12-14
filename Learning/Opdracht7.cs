namespace Learning;

public class Opdracht7
{
    public static void Run()
    {
        var priemgetallen = new List<int>();
        priemgetallen.Add(2); //voeg het eerste priemgetal toe aan priemgetallen list.
        int i = 1; // nummer dat gechecket wordt of het een priemgetal is.
        
        while (priemgetallen.Count < 10) //hoeveel priemgetallen er uiteindelijk in de lijst moeten komen (nu 10)
        {
            i++;
            Boolean ispriem = true;
            //checket i deelbaar is door een priemgetal
            foreach (int priem in priemgetallen)
            {
                if (i % priem == 0) // als i deelbaar is door de priemgetal dan is variabel "i" geen priemgetal
                {
                    ispriem = false;
                    break;
                }
            }
            if (ispriem)
            {
                priemgetallen.Add(i);
            }
        }   
        // print de alle priemgetallen in priemgetallen lijst.
        Console.WriteLine(string.Join(", ",  priemgetallen));
    }
}