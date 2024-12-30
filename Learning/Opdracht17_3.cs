namespace Learning;

public class Opdracht17_3
{
    private char[] _TestData = 
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
        'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    };

    private List<char> _Text;
    private List<char> _RedoChars;
    private ConsoleKeyInfo _Cki;

    public Opdracht17_3()
    {
        _Text = new List<char>();
        _RedoChars = new List<char>();
    }

    public void Run()
    {
        while (true)
        {
            PrintText();
            _Cki = System.Console.ReadKey(); // stopt met de hele tijd dezelfde letter te laten zien als dat ingeput wordt.
            char userInput = _Cki.KeyChar;
            
            //Verwijdert Text
            if (_Cki.Key == ConsoleKey.Backspace)
            {
                RemoveText();
            }
            //Voegt Text toe
            if (CheckValidInput(userInput) || userInput == ' ')
            {
                AddText(userInput);
            }
            //Undo Text
            if ((_Cki.Modifiers & ConsoleModifiers.Control) != 0 && _Cki.Key == ConsoleKey.Z)
            {
                Undo();
            }
            //Redo Text
            if ((_Cki.Modifiers & ConsoleModifiers.Control) != 0 && _Cki.Key == ConsoleKey.Y)
            {
                Redo();
            }
            
        }
    }

    //Checket of de input van user Valid is door _TestData.
    public bool CheckValidInput(char userInput)
    {
        return _TestData.Contains(userInput);
    }

    //Voegt Letter/Input toe aan _Text
    public void AddText(char letter)
    {
        _RedoChars.Clear();
        _Text.Add(letter);
    }

    //verwijdert Text en checket of dit niet buiten _Text List is.
    public void RemoveText()
    {
        if (_Text.Count > 0)
        {
            _Text.RemoveAt(_Text.Count - 1);
        }
    }

    //Verwijdert de Console Prints & Print de Text List.
    public void PrintText()
    {
        Console.Clear();
        Console.WriteLine(new string(_Text.ToArray()));
    }

    //verwijdert alle whitespace of een word per keer dat Undo wordt aangeroepen op basis van laatste char.
    public void Undo()
    {
        int textNumber = _Text.Count-1;
        
        // wordt gebruikt om te zien of Undo Methode het hele woord moet verwijderen of alleen de whitespace (' ') char('s).
        bool removeAllBlanks = _Text[textNumber] == ' ';
        bool removeWord = _TestData.Contains(_Text[textNumber]);  //in range 'a'-'z'
        
            while (true) 
            {
                //verwijderd alle opeenvolgende ' ' als de laatste char ' ' is
                if (_Text[textNumber] != ' ' && removeAllBlanks) break;

                //stopt de loop als het een woord moet removen en de char geen letter is in range 'a'-'z'
                if (!_TestData.Contains(_Text[textNumber]) && removeWord) break;
                
                _RedoChars.Add(_Text[textNumber]);
                _Text.RemoveAt(textNumber);
                textNumber--;
                
                if (textNumber == -1) break; // stopt de loop als het buiten bounds is.
            }
    }
    
    //Redo text dat verwijdert is door Undo methode als er geen letter is toegevoegd met AddText methode.
    public void Redo()
    {
        while (true)
        {
            if (_RedoChars.Count == 0) break;
            //_RedoChars-1 omdat het anders omgekeerd toevoegd ex. abc > cba
            _Text.Add(_RedoChars[_RedoChars.Count-1]);
            _RedoChars.RemoveAt(_RedoChars.Count-1);
            
        }
    }
}