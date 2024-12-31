namespace Learning;

public class Opdracht17_2
{
    public string[,] _testData = new string[15, 2]
    {
        {"Abstractie", "Het proces van het weglaten van minder essentiële informatie zodat alleen de meest essentiële kenmerken overblijven."},
        {"Algoritme", "Een stapsgewijze procedure voor het uitvoeren van een taak of het berekenen van een waarde."},
        {"Array", "Een geordende verzameling elementen, typisch van hetzelfde type."},
        {"Class", "Een blauwdruk voor een object in objectgeoriënteerd programmeren."},
        {"Encapsulatie", "Een objectgeoriënteerd programmeerprincipe waarbij de interne staat van een object verborgen wordt."},
        {"Erfenis", "Het vermogen van een nieuwe klasse om de eigenschappen en methoden van een andere klasse over te nemen."},
        {"Framework", "Een set van codebibliotheken en tools die helpen bij het ontwikkelen van software."},
        {"Interface", "Een contract in OOP dat definieert welke methodes een klasse moet implementeren."},
        {"Iteratie", "Het herhaaldelijk uitvoeren van een set instructies totdat een bepaalde voorwaarde is voldaan."},
        {"Namespace", "Een container die wordt gebruikt om sets van andere benoemde entiteiten onder een unieke naam te groeperen."},
        {"Polymorfisme", "Het vermogen van verschillende klassen om te reageren op dezelfde boodschap op verschillende manieren."},
        {"Recursie", "Een techniek in programmeren waar een functie zichzelf oproept."},
        {"Serialize", "Het proces van omzetten van een object naar een formaat dat kan worden opgeslagen of overgedragen."},
        {"Syntax", "De set regels die definiëren hoe instructies in een programmeertaal zijn opgebouwd."},
        {"Variable", "Een opslaglocatie met een geassocieerde naam en een waarde die kan veranderen tijdens de uitvoering van een programma."}
    };
    //Je hebt 1 key nodig voor 1 value dus 1-1 key-value container moet het zijn, ik dacht toen aan HashSet<T> maar sommige woorden hebben dezelfde definitie, 
    //dus koos ik voor een Dictionary.
    private Dictionary<string, string> _testDataDictionary;
    public Opdracht17_2()
    {
        _testDataDictionary = new Dictionary<string, string>();
        ConvertToDictionary();
    }

    //Dit is de code dat constant runt
    public void Run()
    {
        while (true)
        {
            System.Console.WriteLine("Voer een term in om op te zoeken wat de definitie ervan is.");
            
            string userInput = Convert.ToString(System.Console.ReadLine());
            
            PrintDataFromInput(userInput);
        }
    }

    //converteert _TestData into _TestDataDictionary
    public void ConvertToDictionary()
    {
        for (int i = 0; i < _testData.GetLength(0); i++)
        {
            string term = _testData[i, 0];
            string uitleg = _testData[i, 1];
            _testDataDictionary.Add(term, uitleg);
        }
    }

    //vergelijkt input met dictionary, als dit overeenkomt print het deze data.
    public void PrintDataFromInput(string userInput)
    {
        if (_testDataDictionary.ContainsKey(userInput))
        { 
            System.Console.WriteLine(_testDataDictionary[userInput]);
         return;   
        }
        System.Console.WriteLine("Geen overeenkomende term");
    }
}