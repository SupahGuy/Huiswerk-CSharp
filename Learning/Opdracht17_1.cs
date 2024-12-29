﻿namespace Learning;

public class Opdracht17_1
{
    private string[] _TestData =
    {
        "Emma Mulder", "Sara De Groot", "Emma Bakker", "Milan Van Dijk", "Emma Smit", "Daan Meijer",
        "Julia Visser", "Noah Mulder", "Daan Wengel", "Sara Van Dijk", "Levi De Groot",
        "Tess Visser", "Sem Smit", "Levi Visser", "Sara De Boer"
    };

    private List<string> _TestDataList;

    public Opdracht17_1()
    {
        _TestDataList = _TestData.ToList();
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
        foreach (string name in _TestDataList)
        {
            Console.WriteLine(name + " [" + indexNaam + "]");
            indexNaam++;
        }
    }

    //vraagt om optie dan returnet het de gekozen optie in string.
    public string Opties(int indexInput)
    {
        Console.WriteLine("Contact: " + _TestDataList[indexInput]);
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
        Console.WriteLine("\nNu aan het bellen met " + _TestDataList[indexInput] + "....");
    }

    //verwijdert contact in lijst op basis van user input.
    public void VerwijderContact(int indexInput)
    {
        //eerst laten zien welke contact verwijderd wordt, dan removen.
        
        Console.WriteLine("\nContact: " + _TestDataList[indexInput] + " Is verwijderd.");
        _TestDataList.RemoveAt(indexInput);
    }

}