namespace Learning;

public class Opdracht10
{
    public static void Run()
    {
        int vraagNr = 1;
        int totaalScore = 0;
        
        Console.WriteLine("Welcome to the Great QUiZZ!");

        totaalScore += maakVraag("Wat is 9+10?", "910", "21", "19", "b", vraagNr);
        vraagNr++;
        
        totaalScore += maakVraag("Op welke dag is de eerste kerstdag", "25 December", "23 December", "24 December", "a", vraagNr);
        vraagNr++;
        
        totaalScore += maakVraag("Waar was Alexander de Grote Koning van?", "Italië", "Macedonië", "Albanië", "b", vraagNr);
        vraagNr++;
        
        totaalScore += maakVraag("Hoeveel Kilowatt is een KilowattUur", "1000", "3600", "100", "b", vraagNr);
        vraagNr++;
        
        totaalScore += maakVraag("Hoeveel vragen heeft deze quiz", "4", "1000", "1", "a", vraagNr);
        
        Console.WriteLine("Jouw score is: " + totaalScore);
        Console.WriteLine("Gefelicteerd!");
    }

    
    static int maakVraag(string vraag, string antwoordA, string antwoordB, string antwoordC, string correcteAntwoord, int vraagNr)
    {
        
        Console.WriteLine($"Vraag {vraagNr}: " + vraag);
        
        Console.WriteLine("Antwoord A. " + antwoordA);
        Console.WriteLine("Antwoord B. " + antwoordB);
        Console.WriteLine("Antwoord C. " + antwoordC);
        Console.WriteLine("voer A,B, of C in.");
        
        //voorkomt dat A en a niet hetzelfde is. 
        correcteAntwoord = correcteAntwoord.ToLower(); 
        
        //vraagt om antwoord a,b of c.
        string userInput = Console.ReadLine().ToLower();

        //returnt 1 als vraag goed is zodat score omhoog gaat en 0 als het fout is.
        int returnWaarde = (correcteAntwoord == userInput) ?  1 : 0;

        return returnWaarde;


    }

}