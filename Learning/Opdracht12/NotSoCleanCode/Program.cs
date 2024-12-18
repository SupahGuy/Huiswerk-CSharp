
public class Calculator
{
    public static void RunCalculator()
    {
        while (true)
        {
            Console.WriteLine("Complexere Rekenmachine");
            Console.WriteLine("Kies een operatie: +, -, *, /, % (modulo), 18+ (kassa)");
            string operation = Console.ReadLine();
            
            //inputvalidNumber1 en inputvalidNumber2 wordt validNumber1 en validNumber2 wanneer inputNumber geldig is.
            //dit komt omdat inputvalidNumber1 en 2 een string is zodat het bepaalde functies uit kan voeren.
            
            double validNumber1 = 0;
            double validNumber2 = 0;
            
            bool[] hasDecimalPoint = { false, false };
            
            Console.WriteLine("Voer het eerste getal in:");
            
            string inputvalidNumber1 = Console.ReadLine();

            //Checket inputvalidNumber1 voor geldigheid.
            if (string.IsNullOrWhiteSpace(inputvalidNumber1))
            {
                Console.WriteLine("Ongeldige invoer, geen getal.");
                continue;
            }
            for (int i = 0; i < inputvalidNumber1.Length; i++)
            {
                if (inputvalidNumber1[i] == '.')
                {
                    hasDecimalPoint[0] = true;
                }
                if ((inputvalidNumber1[i] == '-' && i != 0) || !char.IsDigit(inputvalidNumber1[i]) || hasDecimalPoint[0])
                {
                    Console.WriteLine("Ongeldige invoer, geen getal.");
                }
            }

            validNumber1 = Convert.ToDouble(inputvalidNumber1);

            //checket inputvalidNumber2 voor geldigheid als de operatie niet sqrt is
            if (operation != "sqrt")
            {
                Console.WriteLine("Voer het tweede getal in:");
                string inputvalidNumber2 = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(inputvalidNumber2))
                {
                    Console.WriteLine("Ongeldige invoer, geen getal.");
                    continue;
                }
                for (int i = 0; i < inputvalidNumber2.Length; i++)
                {
                    if (inputvalidNumber2[i] == '.')
                    {
                        hasDecimalPoint[0] = true;
                    }
                    if ((inputvalidNumber2[i] == '-' && i != 0) || !char.IsDigit(inputvalidNumber2[i]) || hasDecimalPoint[0])
                    {
                        Console.WriteLine("Ongeldige invoer, geen getal.");
                    }
                }
                validNumber2 = Convert.ToDouble(inputvalidNumber2);
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
        
        // static functies
        
        static void plus(double validNumber1, double validNumber2)
        {
            double temp = validNumber1 + validNumber2;
            Console.WriteLine($"Resultaat: {validNumber1} + {validNumber2} = " + temp);
        }

        static void min(double validNumber1, double validNumber2)
        {
            double temp = validNumber1 - validNumber2;
            Console.WriteLine($"Resultaat: {validNumber1} - {validNumber2} = " + temp);
        }

        static void keer(double validNumber1, double validNumber2)
        {
            double temp = validNumber1 * validNumber2;
            Console.WriteLine($"Resultaat: {validNumber1} * {validNumber2} = " + temp);
        }

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

        static void modulo(double validNumber1, double validNumber2)
        {
            Console.WriteLine($"Resultaat: {validNumber1} % {validNumber2} = " + (validNumber1 % validNumber2));
        }

        static void pow(double validNumber1, double validNumber2)
        {
            double temp = Math.Pow(validNumber1, validNumber2);
            Console.WriteLine($"Resultaat: {validNumber1} ^ {validNumber2} = " + temp);
        }

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

        static void sqrt(double validNumber1, double validNumber2)
        {
            double temp = Math.Sqrt(validNumber1) + Math.Sqrt(validNumber2);
            Console.WriteLine($"Resultaat: √{validNumber1} = " + temp);
        }

        static Boolean vraagRetry()
        {
            Console.WriteLine("Wilt u doorgaan? (ja/nee)");
            //Returnt true als antwoord "ja" is op wilt u doorgaan.
            return Console.ReadLine().ToLower() == "ja";
        }

    }
}