namespace Learning;

public class Opdracht17_3
{
    private char[] _testData = 
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
        'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    };

    //List van char's omdat het simpel is, en voor deze opdracht prima. het is simpelweg een string maar met meer opties zoals add of removeat, deze opdracht zou zonder 
    //List gemaakt kunnen worden maar dit is makkelijker en overzichtelijker coderen.
    private List<char> _text;
    private List<char> _redoList;
    private ConsoleKeyInfo _cki; // heeft de mogelijkheid om te Checken of ctrl of shift enz.(modifier) ingedrukt worden tijdens andere key presses.

    public Opdracht17_3()
    {
        _text = new List<char>();
        _redoList = new List<char>();
    }

    public void Run()
    {
        while (true)
        {
            //Dit laat de actuele text display zien.
            PrintText();
            
            //Wacht totdat er een keypress ingeput wordt.
            _cki = System.Console.ReadKey();
            char userInput = _cki.KeyChar;
            
            //Verwijdert Text
            if (_cki.Key == ConsoleKey.Backspace)
            {
                RemoveText();
            }
            //Voegt Text toe
            if (CheckValidInput(userInput) || userInput == ' ')
            {
                AddText(userInput);
            }
            //Undo Text
            if ((_cki.Modifiers & ConsoleModifiers.Control) != 0 && _cki.Key == ConsoleKey.Z)
            {
                Undo();
            }
            //Redo Text
            if ((_cki.Modifiers & ConsoleModifiers.Control) != 0 && _cki.Key == ConsoleKey.Y)
            {
                Redo();
            }
        }
    }

    //Checket of de input van user Valid is door _testData.
    public bool CheckValidInput(char userInput)
    {
        return _testData.Contains(userInput);
    }

    //Voegt Letter/Input toe aan _text
    public void AddText(char letter)
    {
        _redoList.Clear();
        _text.Add(letter);
    }

    //verwijdert Text en checket of dit niet buiten _text List is.
    public void RemoveText()
    {
        if (_text.Count > 0)
        {
            _text.RemoveAt(_text.Count - 1);
        }
    }

    //Verwijdert de Console Prints & Print de Text List(updatet de WriteLine wanneer er iets gebeurd).
    public void PrintText()
    {
        Console.Clear();
        Console.WriteLine(new string(_text.ToArray()));
    }

    //verwijdert alle whitespace of een word per keer dat Undo wordt aangeroepen op basis van laatste char.
    public void Undo()
    {
        int textNumber = _text.Count-1;
        if (_text.Count == 0) return; // stopt Undo als het buiten bounds is.
        
        // wordt gebruikt om te zien of Undo Methode het hele woord moet verwijderen of alleen de whitespace (' ') char('s).
        bool removeAllBlanks = _text[textNumber] == ' ';
        bool removeWord = _testData.Contains(_text[textNumber]);  //in range 'a'-'z'
        
            while (true) 
            {
                if (textNumber == -1) break; // stopt de loop als het buiten bounds is.
                
                //verwijderd alle opeenvolgende ' ' als de laatste char ' ' is
                if (_text[textNumber] != ' ' && removeAllBlanks) break;

                //stopt de loop als het een woord moet removen en de char geen letter is in range 'a'-'z'
                if (!_testData.Contains(_text[textNumber]) && removeWord) break;
                
                _redoList.Add(_text[textNumber]);
                _text.RemoveAt(textNumber);
                textNumber--;
                
            }
    }
    
    //Redo text dat verwijdert is door Undo methode als er geen letter is toegevoegd met AddText methode.
    public void Redo()
    {
        while (true)
        {
            if (_redoList.Count == 0) break;
            //_redoList-1 omdat het anders omgekeerd letters toevoegd aan _text ex. abc > cba
            _text.Add(_redoList[_redoList.Count-1]);
            _redoList.RemoveAt(_redoList.Count-1);
        }
    }
}