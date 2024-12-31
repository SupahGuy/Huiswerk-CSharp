namespace Learning;

public class Opdracht17_1
{
    private string[] _testData =
    {
        "Emma Mulder", "Sara De Groot", "Emma Bakker", "Milan Van Dijk", "Emma Smit", "Daan Meijer",
        "Julia Visser", "Noah Mulder", "Daan Wengel", "Sara Van Dijk", "Levi De Groot",
        "Tess Visser", "Sem Smit", "Levi Visser", "Sara De Boer"
    };

    //Ik gebruik deze container omdat het makkelijk is om mee te werken, En er geen key-value nodig is of een set.
    //Dit doe ik omdat voor deze opdracht het hét beste wegens de _TestData
    //Als dit een échte contactenlijst zou zijn met telefoonnummer dan zou ik kiezen voor Dictionary (telnum, naam), en als dit ook nog eens
    //persoonsgegevens nodig zou hebben dan een linkedlist. Nooit een Set nodig omdat duplicaten contacten hebben geen probleem is.
    private List<string> _testDataList;

    public Opdracht17_1()
    {
        _testDataList = _testData.ToList();
    }

    public void Run()
    {
        while (true)
        {
            PrintContactLijst();
            
            Console.WriteLine("Toets een contact zijn nummer in voor opties. \n");
            
            int indexInput = Convert.ToInt32(Console.ReadLine()) - 1;
            
            string gekozenOptie = Opties(indexInput);
            
            //doet een taak op basis van user input.
            switch (gekozenOptie)
            {
                case "bellen":
                    BelNaam(indexInput);
                    break;
                case "verwijder":
                    VerwijderContact(indexInput);
                    break;
            }
            
            Console.WriteLine("\nToets een key in om verder te gaan...");
            Console.ReadLine();
        }
    }

    public void PrintContactLijst()
    {
        int indexNaam = 1; // gebruikt om index te weergeven voor gebruiker
        foreach (string name in _testDataList)
        {
            Console.WriteLine(name + " [" + indexNaam + "]");
            indexNaam++;
        }
    }

    //vraagt om optie dan returnet het de gekozen optie in string.
    public string Opties(int indexInput)
    {
        Console.WriteLine("Contact: " + _testDataList[indexInput]);
        Console.WriteLine("Toets 1 om te bellen.");
        Console.WriteLine("Toets 2 om dit contact te verwijderen.");
        
        int gekozenOptieGebruiker = Convert.ToInt32(Console.ReadLine());
        string gekozenOptieReturn = "";
        
        if (gekozenOptieGebruiker == 1)
        {
            gekozenOptieReturn = "bellen";
        }

        if (gekozenOptieGebruiker == 2)
        {
            gekozenOptieReturn = "verwijder";
        }

        return gekozenOptieReturn;
    }

    //simuleert bellen met contact op basis van user input.
    public void BelNaam(int indexInput)
    {
        Console.WriteLine("\nNu aan het bellen met " + _testDataList[indexInput] + "....");
    }

    //verwijdert contact in lijst op basis van user input.
    public void VerwijderContact(int indexInput)
    {
        //eerst laten zien welke contact verwijderd wordt, dan removen.
        
        Console.WriteLine("\nContact: " + _testDataList[indexInput] + " Is verwijderd.");
        _testDataList.RemoveAt(indexInput);
    }

}