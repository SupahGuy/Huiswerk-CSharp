namespace Learning;

public class Opdracht17_7
{
    private string[] _music = new string[]
    {
        "Lady Gaga -Shallow",
        "Drake -Memories", "Shawn Mendes -Blinding Lights", "Maroon 5 -Memories", "Adele -Shallow", "Lady Gaga -Yellow",
        "The Weeknd-Leave the Door Open",
        "Imagine Dragons -Positions",
        "Adele -Positions",
        "The Weeknd -Someone Like You", 
        "Adele -Positions", "Coldplay -Memories", "Dua Lipa -Good 4 U",
        "Billie Eilish -Blinding Lights", "Drake -Leave the Door Open"
    };

    //Ik kies voor deze opdracht de container List, Omdat er duplicates in de list moeten komen dus HashSet etc. lukt niet.
    //En er moet makkelijk kunnen wijzigen van index-positie dus lijkt list het beste voor de taak. :) 

    private List<string> _musicList;
    
    public Opdracht17_7()
    {
        _musicList = _music.ToList();
    }


    public void Run()
    {
        while (true)
        {
            //vangt foutieve input op
            try
            {
                PrintAfspeelLijst();
                
                Console.WriteLine("1= Nummer toevoegen, 2= Nummer verplaatsen");
                int userKeuze = Convert.ToInt32(Console.ReadLine());

                switch (userKeuze)
                {
                    case 1:
                        VoegNummerToe();
                        break;
                    case 2:
                        VerplaatsNummer();
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze, Probeer opnieuw");
                        break;
                }
            }
            //Laat zien wat er fout ging. als foutieve input opgegeven is.
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public void PrintAfspeelLijst()
    {
        int i = 0;
        foreach (string music in _musicList)
        {
            i++;
            Console.WriteLine(music + " [" + i + "]");
        }
    }

    public void VoegNummerToe()
    {
        Console.WriteLine("Wat is de naam van de artiest?");
        string muziekNummer = Console.ReadLine();

        Console.WriteLine("Wat is de naam van de nummer?");
        muziekNummer += " -" + Console.ReadLine();
        
        _musicList.Add(muziekNummer);
    }

    public void VerplaatsNummer()
    {
        Console.WriteLine("Kies nummer om te verplaatsen");
        int gekozenNummerIndex = Convert.ToInt32(Console.ReadLine())-1;
        
        Console.WriteLine("Na welke nummer moet het gaan (Geef index)");
        int verplaatsNummerIndex = Convert.ToInt32(Console.ReadLine())-1;
        
        string gekozenNummer = _musicList[gekozenNummerIndex];
        
        _musicList.RemoveAt(gekozenNummerIndex); //Verwijdert oude Nummer
        
        _musicList.Insert(verplaatsNummerIndex, gekozenNummer); // Insert de oude nummer op de nieuwe plaats
    }
}