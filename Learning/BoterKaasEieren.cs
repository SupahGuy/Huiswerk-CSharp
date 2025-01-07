namespace Learning;

public class BoterKaasEieren
{
    private Dictionary<int, string> _boardstate;
    private int _userScore;
    private int _aiScore;
    private int _ties;

    public BoterKaasEieren()
    {
        //The int is the position(left to right top to bottom), char if not null is the X or O.
        // X = User.
        // O = AI.
        _boardstate = new Dictionary<int, string>();

    }

    public void Run()
    {
        CreateBoard();

        while (true)
        {
            //clears the board if theres a winning position.

            DisplayBoardState();

            Console.WriteLine("Voer nummer in.(1-9)");

            int inputGebruiker = Convert.ToInt32(System.Console.ReadLine());

            if (!UserMakeMove(inputGebruiker)) continue;

            if (CheckIfWon())
            {
                EndBoardState("User");
                continue;
            }

            if (CheckIfTie())
            {
                EndBoardState("Tie");
                continue;
            }
            
            EnemyMakeRandomMove();

            if (CheckIfWon())
            {
                EndBoardState("Ai");
                continue;
            }

            if (CheckIfTie())
            {
                EndBoardState("Tie");
                continue;
            }

        }
    }

    //Displays the score
    public void DisplayScore()
    {
        Console.WriteLine($"Score: You:{_userScore}-AI:{_aiScore} Ties: {_ties}");
    }

    //Creates a the variables for the 3x3 board.
    public void CreateBoard()
    {
        // for every index the value is index+1, so [0] = 1.
        for (int i = 0; i <= 8; i++)
        {
            _boardstate.Add(i, $"{i + 1}");
        }
    }

    public void ClearBoard()
    {
        for (int i = 0; i <= 8; i++)
        {
            _boardstate[i] = $"{i + 1}";
        }
    }

    //checks if move is valid. it is valid whenever the chosen number hasn't already been chosen.
    public bool CheckValidMove(int userInput)
    {
        //try catch for out of bounds errors.
        try
        {
            if (_boardstate[userInput - 1] == Convert.ToString(userInput)) return true;
        }
        catch (Exception e)
        {
            return false;
        }

        return false;
    }

    //makes move if move is valid.
    public bool UserMakeMove(int userInput)
    {
        //if the move is invalid 
        if (!CheckValidMove(userInput))
        {
            Console.WriteLine("Input is ongeldig.");
            return false;
        }

        //changes the boardstate
        _boardstate[userInput - 1] = "X";
        return true;
    }

    //makes the AI make a random valid move.
    public void EnemyMakeRandomMove()
    {
        Random rnd = new Random();
        while (true)
        {
            foreach (string value in _boardstate.Values)
            {
                //checks if value is already taken by user or ai.
                if (value == "X" || value == "O") continue;

                //checks if random number is the same as value. and makes a move if possible.
                if (Convert.ToInt32(value) == rnd.Next(1, 9))
                {
                    Console.WriteLine("AI: Makes move on: " + value);
                    _boardstate[Convert.ToInt32(value) - 1] = "O";
                    return;
                }
            }
            
        }
    }

    public bool CheckIfWon()
    {
        //used to see if boardstates value is either x or o
        string[] xOrYString = { "X", "O" };
        
        //Horizontal check
        for (int i = 0; i <= 6; i = i + 3)
        {
            foreach (var xOrY in xOrYString)
            {
                if (_boardstate[0 + i] == xOrY && _boardstate[1 + i] == xOrY && _boardstate[2 + i] == xOrY)
                {
                    return true;
                }
            }
        }
        
        //Vertical check
        for (int i = 0; i <= 2; i++)
        {
            foreach (var xOrY in xOrYString)
            {
                if (_boardstate[0 + i] == xOrY && _boardstate[3 + i] == xOrY && _boardstate[6 + i] == xOrY)
                {
                    return true;
                }
            }
        }

        //Criss Cross check (top left to bottom right, top right to bottom left)
        foreach (var xOrO in xOrYString)
        {
            //top left, bottom right
            if (_boardstate[0] == xOrO && _boardstate[4] == xOrO && _boardstate[8] == xOrO)
            {
                return true;
            }

            //top right, bottom left
            if (_boardstate[2] == xOrO && _boardstate[4] == xOrO && _boardstate[6] == xOrO)
            {
                return true;
            }
        }
        
        return false;
    }

    public void EndBoardState(string reason)
    {
        if (reason == "User")
        {
            _userScore++;
            Console.WriteLine("YOU WON!!!");
        }

        if (reason == "Ai")
        {
            _aiScore++;
            Console.WriteLine("You lost... Womp Womp");
        }

        if (reason == "Tie")
        {
            _ties++; //increase tie amount.
            Console.WriteLine("Er is een gelijkspel.....");
        }

        Console.WriteLine("Final Board State:");
        DisplayBoardState();
        DisplayScore();
        
        Console.WriteLine("Type any key to continue...");
        Console.ReadKey();

        ClearBoard();
    }

    public void DisplayBoardState()
    {
        System.Console.WriteLine($"{_boardstate[0]} | {_boardstate[1]} | {_boardstate[2]}");
        System.Console.WriteLine("----------");
        System.Console.WriteLine($"{_boardstate[3]} | {_boardstate[4]} | {_boardstate[5]}");
        System.Console.WriteLine("----------");
        System.Console.WriteLine($"{_boardstate[6]} | {_boardstate[7]} | {_boardstate[8]}");
    }

    public bool CheckIfTie()
    {
        int countOfInvalidSpaces = 0;
        foreach (var value in _boardstate.Values)
        {
            if (value == "X" || value == "O")
            {
                countOfInvalidSpaces++;
            }
        }

        if (countOfInvalidSpaces == 9) return true;
        
        return false;
    }



}