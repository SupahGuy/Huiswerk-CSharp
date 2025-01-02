namespace Learning;

public class Opdracht17_8
{
    private string[] _containers = new string[]
    {
        "QVDM8009762", "CJIG1905934", "FGCM4664607", "CFLG6697633", "EQOD4660076",
        "PGLD2285677", "IISX5619237", "QMNU0970619", "SXKB8127565", "WBGZ9043382", 
        "BVLZ9518548", "ZNSF2844985", "MRMV5005868", "PSWG7783254", "MYXT5104082",
        "GATM3160561", "XTXY3685126", "JFGQ5602926", "ICKQ5740110", "LLEN8095860",
        "DJQQ9473760", "MLUL9881099", "ZVZT6648738", "ZCFF1692285", "KDQD6427718",
        "KDQD6427718"
    };

    //wordt gebruikt om _containerstapel lengte te geven.
    private int _maxStackLength = 5;
    
    //wordt gebruikt om te checken of er open plekken zijn.
    private int _maxAmountStacks = 10;
    
    //Ik dacht er aan om een queue te gebruiken, maar toen leek een list van string[_maxlengte]'s het beste en dan index [0] is de eerste container tot [_maxlengte-1].
    //Toen zag ik dat elke container uniek moet zijn dus HashSet<String[_maxLengte]> lijkt het beste want dan heb je unieke string arrays van _maxLengte.
    //Het blijkt dat dit niet per string checket maar per string array checket of dit uniek is dus is dit niet handig.
    //Maar toen zag ik de Container Stack<T>, die kan ik gebruiken als stapels en die in een List doen: dus een list van stapels.
    
    //dit vindt ik de beste oplossing want HashSet haalt alle non-unique strings weg, en List<Stack<T>> is de reële lijst waar alle containers in "staan".

    //_containerHashSet is er om unieke waardes te checken. en wordt gebruikt om te checken welke containers er nu zijn in de haven.
    private HashSet<string> _containerHashSet;
    private List<Stack<string>> _containerStackList;
    
    public Opdracht17_8()
    {
        _containerHashSet = new HashSet<string>();
        _containerStackList = new List<Stack<string>>();
        DataInList();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Opties:\n" +
                                     "1 = Print Containers (Cleart de Console)\n" +
                                     "2 = Voeg Container toe\n" +
                                     "3 = Container ophalen");
            int userOptie = Convert.ToInt32(Console.ReadLine());
            switch (userOptie)
            {
                case 1:
                    PrintContainers();
                    break;
                case 2:
                    AddContainer();
                    break;
                case 3:
                    GetContainer();
                    break;
                default:
                    Console.WriteLine("Onbekende optie.");
                    break;
            }
        }
    }
    
    //converteert alle test data naar _containerStackList.
    public void DataInList()
    {
        foreach (string container in _containers)
        {
            _containerHashSet.Add(container);
        }
        
        //veranderd de Data naar unieke container strings
        string[] tempUniqueContainers = new string[_containerHashSet.Count];
        _containerHashSet.CopyTo(tempUniqueContainers);
        
        //gebruikt om out of bounds te catchen
        int tempUniqueContainersPlaced = 0;
        
        //doet de maximale aantal containers per Stack(_maxStackLength) in een Stack<string> en dan in de List<Stack<string>>
        while (_containerStackList.Count < _maxAmountStacks)
        {
            Stack<string> tempStack = new Stack<string>();

            for (int j = 0; j < _maxStackLength; j++)
            {
                if (tempUniqueContainers.Length == tempUniqueContainersPlaced) break;

                tempStack.Push(tempUniqueContainers[tempUniqueContainersPlaced]);
                tempUniqueContainersPlaced++;
            }
            _containerStackList.Add(tempStack);
        }
    }

    //print alle containers in _containerStackList met een overzichtelijke index.
    public void PrintContainers()
    {
        int stackIndex = 0;
        
        foreach (Stack<string> containerStack in _containerStackList)
        {
            stackIndex++;
            
            int containerIndex = 0;
            //copiert container stack naar een tempstack zodat het een voor een van bovenaf de stack de containers print.
            
            foreach (string container in containerStack)
            {
                Console.WriteLine($"ContainerID Nummer:{container} Stack: [{stackIndex}] container: [{containerIndex+1}] (1 is de bovenste {_maxStackLength} is onderste)");
                containerIndex++;
            }
        }
    }

    //voegt de container toe aan de eerste mogelijke plek. en doet dit in de _containerHashSet.
    public void AddContainer()
    {
        Console.WriteLine("Wat is de container nummer?");
        string userContainerNummer = Console.ReadLine();

        if (_containerHashSet.Contains(userContainerNummer))
        {
            Console.WriteLine("Error: Container nummer is niet uniek.");
            return;
        }
        
        int stackIndex = 0;
        
        //checket elke stapel 1 voor 1 of het minder dan de dan de max is en voegt het de container toe aan die stack.
        foreach (Stack<string> stack in _containerStackList)
        {
            stackIndex++;
            if (stack.Count < _maxStackLength)
            {
                Console.WriteLine("Container is succesvol op stack: " + stackIndex + " Geplaatst.");
                stack.Push(userContainerNummer);
                _containerHashSet.Add(userContainerNummer);
                return;
            }
        }
        //Als er geen Plaats is dan print het dit.
        Console.WriteLine("Niet genoeg plek.");
    }
    
    
    //verplaats containers zodat het toegangbaar is vanuit de bovenkant en laat zien hoe in Console.
    //Doet dit met unieke container id nummer input.
    public void GetContainer()
    {
        System.Console.WriteLine("Wat is de Unieke Nummer van de container dat u wilt ophalen?");
        string userContainerNummer = Console.ReadLine();

        //checkt of container in de haven zit.
        if (!_containerHashSet.Contains(userContainerNummer))
        {
            Console.WriteLine("Container zit niet in de haven.");
            return;
        }
        int positionWantedContainerStack = 0;
        bool foundWantedContainer = false;
        int positionWantedContainer = 0;
        //haalt de Stack nummer en Container nummer uit de _containerStackList (wordt gebruikt om te checken of container toegangbaar is later)
        //laat ook precies elke stap die gezet wordt in het écht.
        foreach (var stack in _containerStackList)
        {
            positionWantedContainer = 0;
            
            //zoekt de Container.
            foreach (var container in stack)
            {
                if (userContainerNummer == container)
                {
                    foundWantedContainer = true;
                    break;
                }
                positionWantedContainer++;
            }
            if (foundWantedContainer)
            {
                Console.WriteLine("Container positie is gevonden in stack " + (positionWantedContainerStack) + " en Nr. " + (positionWantedContainer+1));
                break;
            }
            
            positionWantedContainerStack++;
        }

        //wordt gebruikt om de container te "bewegen" (de hijskraan)
        string tempMovingContainer = "";
        
        Console.WriteLine("\nHijskraan begint nu met bewegen:");
        while (true)
        {
            if (userContainerNummer == _containerStackList[positionWantedContainerStack].Peek())
            {
                //TODO: je hebt het gevonden nu wat?
                Console.WriteLine("Container is nu toegangbaar bovenaan stack: " + (positionWantedContainerStack+1));
                break;
            }

            int tempCurrentContainerStack = 0;
            //let uit in console wanneer het dingen van de stack haalt en ergens anders op zet.
            foreach (var stack in _containerStackList)
            {
                //Doet de hijskraan zijn container op de stack als het niet vol zit.
                while (stack.Count < _maxStackLength)
                {
                    //voorkomt dat de hijskraan steeds dezelfde container oppakt en neerplaatst op dezelfde stack.
                    if (tempCurrentContainerStack == positionWantedContainerStack) break;
                    
                    if (userContainerNummer == _containerStackList[positionWantedContainerStack].Peek()) break;
                    
                    //doe container op hijskraan als hijskraan leeg is.
                    if (tempMovingContainer == "")
                    {
                        Console.WriteLine("Zet container ID: " + _containerStackList[positionWantedContainerStack].Peek() + " Stack: " + (positionWantedContainerStack) + " op de hijskraan");
                        tempMovingContainer = _containerStackList[positionWantedContainerStack].Pop();
                    }   
                    
                    Console.WriteLine("Doe deze container op stack " + (tempCurrentContainerStack+1) + ".");
                    stack.Push(tempMovingContainer);
                    tempMovingContainer = "";
                }

                tempCurrentContainerStack++;
            }
        }
    }
}