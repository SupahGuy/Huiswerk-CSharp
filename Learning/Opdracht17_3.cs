namespace Learning;

public class Opdracht17_3
{
    private char[] _TestData = 
    {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
        'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' '
    };

    private List<char> _Text;
    private ConsoleKeyInfo _Cki;
    //used for Undo & Redo
    private bool _NewInput;

    public Opdracht17_3()
    {
        _Text = new List<char>();
    }

    public void Run()
    {
        while (true)
        {
            PrintText();
            
            
            _NewInput = false;
            _Cki = System.Console.ReadKey(); // stopt met de hele tijd dezelfde letter te laten zien als dat ingeput wordt.
            char userInput = _Cki.KeyChar;
            
            
            //Verwijdert Text
            if (_Cki.Key == ConsoleKey.Backspace)
            {
                RemoveText();
            }
            //Voegt Text toe
            if (CheckValidInput(userInput))
            {
                AddText(userInput);
            }

            if ((_Cki.Modifiers & ConsoleModifiers.Control) != 0 && _Cki.Key == ConsoleKey.Z)
            {
                Undo();
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
        _NewInput = true;
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

    public void Undo()
    {
        int textNumber = _Text.Count-1;
        if (_Text.Contains(' ') && _Text.Count >= 1)
        {
            while (true)
            {
                //TODO: Remove till a word is deleted & Redo Function
                _Text.RemoveAt(textNumber);
                textNumber--;
            }
        }
    }
}