
public class Calculator
{
    public static void RunCalculator()
    {
        while (true)
        {
            Console.WriteLine("Complexere Rekenmachine");
            Console.WriteLine("Kies een operatie: +, -, *, /, % (modulo), 18+ (kassa)");
            string operation = Console.ReadLine();
            
            //inputNumber1 en inputNumber2 wordt validNumber1 en validNumber2 wanneer inputNumber geldig is.
            //dit komt omdat inputNumber1 en 2 een string is zodat het bepaalde functies uit kan voeren.
            
            double validNumber1 = 0;
            double validNumber2 = 0;
            
            bool[] hasDecimalPoint = { false, false };
            
            Console.WriteLine("Voer het eerste getal in:");
            
            string inputNumber1 = Console.ReadLine();

            //Checket inputNumber1 voor geldigheid.
            
            if (string.IsNullOrWhiteSpace(inputNumber1))
            {
                Console.WriteLine("Ongeldige invoer, geen getal.");
                continue;
            }
            for (int i = 0; i < inputNumber1.Length; i++)
            {
                if (inputNumber1[i] == '.')
                {
                    if (hasDecimalPoint[0])
                    {
                        Console.WriteLine("Ongeldige invoer, geen getal.");
                    }
                    hasDecimalPoint[0] = true;
                }
                else if (inputNumber1[i] == '-')
                {
                    if (i != 0)
                    {
                        Console.WriteLine("Ongeldige invoer, geen getal.");
                    }
                }
                else if (!char.IsDigit(inputNumber1[i]))
                {
                    Console.WriteLine("Ongeldige invoer, geen getal.");
                }
            }
            validNumber1 = Convert.ToDouble(inputNumber1);

            //checket inputNumber2 voor geldigheid als de operatie niet sqrt is
            
            if (operation != "sqrt")
            {
                Console.WriteLine("Voer het tweede getal in:");
                string inputNumber2 = Console.ReadLine();
                
                
                if (string.IsNullOrWhiteSpace(inputNumber2))
                {
                    Console.WriteLine("Ongeldige invoer, geen getal.");
                    continue;
                }
                for (int i = 0; i < inputNumber2.Length; i++)
                {
                    if (inputNumber2[i] == '.')
                    {
                        if (hasDecimalPoint[1])
                        {
                            Console.WriteLine("Ongeldige invoer, geen getal.");
                        }
                        hasDecimalPoint[1] = true;
                    }
                    else if (inputNumber2[i] == '-')
                    {
                        if (i != 0)
                        {
                            Console.WriteLine("Ongeldige invoer, geen getal.");
                        }
                    }
                    else if (!char.IsDigit(inputNumber2[i]))
                    {
                        Console.WriteLine("Ongeldige invoer, geen getal.");
                    }
                }
                
                validNumber2 = Convert.ToDouble(inputNumber2);
            }

            //kiest aan de hand van input operatie welke operatie het doet.
            switch (operation)
            {
                case "+":
                    plus(validNumber1, validNumber2);
                    break;
                case "-":
                    min(validNumber1, validNumber2);
                    break;
                case "*":
                    keer(validNumber1, validNumber2);
                    break;
                case "/":
                    gedeeld(validNumber1, validNumber2);
                    break;
                case "%":
                    modulo(validNumber1,validNumber2);
                    break;
                case "^":
                    pow(validNumber1, validNumber2);
                    break;
                case "18+":
                    ouderDan18(validNumber1, validNumber2);
                    break;
                case "sqrt":
                    sqrt(validNumber1, validNumber2);
                    break;
                default:
                    System.Console.WriteLine("Ongeldige operatie");
                    break;
            }
            if (!vraagRetry()) break; // stopt calculator als antwoord niet "ja" is.
        }
        
        // Static Functies
        
        //functie wanneer operator "+" wordt gekozen
        static void plus(double validNumber1, double validNumber2)
        {
            double temp = validNumber1 + validNumber2;
            Console.WriteLine($"Resultaat: {validNumber1} + {validNumber2} = " + temp);
        }

        //functie wanneer operator "-" wordt gekozen
        static void min(double validNumber1, double validNumber2)
        {
            double temp = validNumber1 - validNumber2;
            Console.WriteLine($"Resultaat: {validNumber1} - {validNumber2} = " + temp);
        }

        //functie wanneer operator "*" wordt gekozen
        static void keer(double validNumber1, double validNumber2)
        {
            double temp = validNumber1 * validNumber2;
            Console.WriteLine($"Resultaat: {validNumber1} * {validNumber2} = " + temp);
        }

        //functie wanneer operator "/" wordt gekozen
        static void gedeeld(double validNumber1, double validNumber2)
        {
            if (validNumber2 != 0)
            {
                double temp = validNumber1 / validNumber2;
                Console.WriteLine($"Resultaat: {validNumber1} / {validNumber2} = " + temp);
            }
            else
            {
                Console.WriteLine("Delen door nul is niet toegestaan.");
            }
        }

        //functie wanneer operator "%" wordt gekozen
        static void modulo(double validNumber1, double validNumber2)
        {
            Console.WriteLine($"Resultaat: {validNumber1} % {validNumber2} = " + (validNumber1 % validNumber2));
        }

        //functie wanneer operator "^" wordt gekozen
        static void pow(double validNumber1, double validNumber2)
        {
            double temp = Math.Pow(validNumber1, validNumber2);
            Console.WriteLine($"Resultaat: {validNumber1} ^ {validNumber2} = " + temp);
        }

        //functie wanneer operator "18+" wordt gekozen
        static void ouderDan18(double validNumber1, double validNumber2)
        {
            
            Console.WriteLine("Voer het jaartal in:");
            string year = Console.ReadLine();
                
            if (string.IsNullOrWhiteSpace(year))
            {
                Console.WriteLine("Ongeldige invoer, geen getal.");
            }

            for (int i = 0; i < year.Length && year.Length == 4; i++)
            {
                if (year[i] == '.' || year[i] == '-' || !char.IsDigit(year[i]))
                {
                    Console.WriteLine("Ongeldige invoer, geen jaartal.");
                }
            }

            int inputDag = Convert.ToInt32(validNumber1);
            int inputMaand = Convert.ToInt32(validNumber2);
            int inputJaar = Convert.ToInt32(year);
            
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            DateOnly inputDate = new DateOnly(inputJaar, inputMaand, inputDag);
            
            //doet -18 jaar op currentDate en vergelijkt dan of inputDate groter is dan CurrentDate
            
            if (currentDate.AddYears(-18) < inputDate)
            {
                Console.WriteLine($"Resultaat: jonger dan 18!");
            }
            else
            {
                Console.WriteLine($"Resultaat: 18+");
            }
            
            
        }
        
        //functie wanneer operator "sqrt" wordt gekozen
        static void sqrt(double validNumber1, double validNumber2)
        {
            double temp = Math.Sqrt(validNumber1) + Math.Sqrt(validNumber2);
            Console.WriteLine($"Resultaat: √{validNumber1} = " + temp);
        }
        
        //functie dat vraagt of je een nieuwe berekening doen, wanneer "ja" wordt beantwoord gaat de while loop door van Calculator.
        static Boolean vraagRetry()
        {
            Console.WriteLine("Wilt u doorgaan? (ja/nee)");
            //Returnt true als antwoord "ja" is op wilt u doorgaan.
            return Console.ReadLine().ToLower() == "ja";
        }

    }
}