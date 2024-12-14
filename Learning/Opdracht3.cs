namespace Learning;

public class Opdracht3
{
    public static void Run()
    {
        //minVal is het minimale nummer dat het spel kan hebben en maxVal het maximale
        var minVal = 1;
        var maxVal = 99;
        var geheimNummer = Random.Shared.Next(minVal, maxVal + 1);

        Console.WriteLine($"Hoger of Lager spel, voer een nummer tussen {minVal} en {maxVal} in");

        while (true)
            try
            {
                var userInputNumber = Convert.ToInt32(Console.ReadLine());
                //Checket of de input tussen Minval en Maxval ligt
                if (userInputNumber > maxVal || userInputNumber < minVal)
                {
                    Console.WriteLine("Error: Nummer te groot of te Klein.");
                    continue; // zorgt ervoor dat er niet hoger of lager geprint wordt ookal is het getal hoger dan maxval/ lager dan minval
                }

                if (userInputNumber > geheimNummer) Console.WriteLine("Het geheime nummer is lager.");

                if (userInputNumber < geheimNummer) Console.WriteLine("Het geheime nummer is hoger.");

                if (userInputNumber == geheimNummer)
                {
                    Console.WriteLine("Goed Geraden! Het geheime nummer is inderdaad " + geheimNummer);
                    break; // stopt de loop als het nummer geraden is.
                }

            }
            //Pakt onverwachte errors zoals dat de nummer groter is dan een 32bit-integer
            catch (Exception e)
            {
                Console.WriteLine("Error: Probeer Opnieuw (Alleen Natuurlijke Getallen.)");
            }
    }
}