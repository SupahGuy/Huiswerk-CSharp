Calculator();

void Calculator()
{
    while (true)
    {
        Console.WriteLine("Complexere Rekenmachine");
        Console.WriteLine("Kies een operatie: +, -, *, /, % (modulo), 18+ (kassa)");
        
        string operation = Console.ReadLine();
        double number1 = 0;
        double number2 = 0;
        
        Console.WriteLine("Voer het eerste getal in:");
        
        //User input1
        string input1 = Console.ReadLine();
        
        
        if (string.IsNullOrWhiteSpace(input1))
        {
            Console.WriteLine("Ongeldige invoer, geen getal.");
            continue;
        }

        bool[] hasDecimalPoint = { false, false };
        for (int i = 0; i < input1.Length; i++)
        {
            if (input1[i] == '.')
            {
                if (hasDecimalPoint[0])
                {
                    Console.WriteLine("Ongeldige invoer, geen getal.");
                }
                hasDecimalPoint[0] = true;
            }
            else if (input1[i] == '-')
            {
                if (i != 0)
                {
                    Console.WriteLine("Ongeldige invoer, geen getal.");
                }
            }
            else if (!char.IsDigit(input1[i]))
            {
                Console.WriteLine("Ongeldige invoer, geen getal.");
            }
        }
        
        number1 = Convert.ToDouble(input1);

        if (operation != "sqrt")
        {
            Console.WriteLine("Voer het tweede getal in:");
            string input2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input2))
            {
                Console.WriteLine("Ongeldige invoer, geen getal.");
                continue;
            }

            for (int i = 0; i < input2.Length; i++)
            {
                if (input2[i] == '.')
                {
                    if (hasDecimalPoint[1])
                    {
                        Console.WriteLine("Ongeldige invoer, geen getal.");
                    }
                    hasDecimalPoint[1] = true;
                }
                else if (input2[i] == '-')
                {
                    if (i != 0)
                    {
                        Console.WriteLine("Ongeldige invoer, geen getal.");
                    }
                }
                else if (!char.IsDigit(input2[i]))
                {
                    Console.WriteLine("Ongeldige invoer, geen getal.");
                }
            }
        }

        //kiest aan de hand van operatie
        switch (operation)
        {
            case "+":
                plus(number1, number2);
                break;
            case "-":
                System.Console.WriteLine("-");
                break;
            case "*":
                System.Console.WriteLine("*");
                break;
            case "/":
                System.Console.WriteLine("/");
                break;
            case "%":
                System.Console.WriteLine("%");
                break;
            case "18+":
                System.Console.WriteLine("18+");
                break;
            case "sqrt":
                System.Console.WriteLine("sqrt");
                break;
        }

        if (operation == "-")
        {
            double temp = number1 - number2;
            Console.WriteLine($"Resultaat: {number1} - {number2} = " + temp);
        }
        else if (operation == "*")
        {
            double temp = number1 * number2;
            Console.WriteLine($"Resultaat: {number1} * {number2} = " + temp);
        }
        else if (operation == "/")
        {
            double temp = number1 / number2;
            if (number2 != 0)
            {
                Console.WriteLine($"Resultaat: {number1} / {number2} = " + temp);
            }
            else
            {
                Console.WriteLine("Delen door nul is niet toegestaan.");
            }
        }
        else if (operation == "%")
        {
            double temp = number1 % number2;
            Console.WriteLine($"Resultaat: {number1} % {number2} = " + temp);
        }
        else if (operation == "^")
        {
            double temp = Math.Pow(number1, number2);
            Console.WriteLine($"Resultaat: {number1} ^ {number2} = " + temp);
        }
        else if (operation == "sqrt")
        {
            double temp = Math.Sqrt(number1) + Math.Sqrt(number2);
            Console.WriteLine($"Resultaat: √{number1} = " + temp);
        }
        else if (operation == "18+")
        {
            Console.WriteLine("Voer het jaartal in:");
            string year = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(year))
            {
                Console.WriteLine("Ongeldige invoer, geen getal.");
                continue;
            }
            else
            {
                for (int i = 0; i < year.Length && year.Length == 4; i++)
                {
                    if (year[i] == '.')
                    {
                        Console.WriteLine("Ongeldige invoer, geen jaartal.");
                        continue;
                    }
                    else if (year[i] == '-')
                    {
                        Console.WriteLine("Ongeldige invoer, geen jaartal.");
                        continue;
                    }
                    else if (!char.IsDigit(year[i]))
                    {
                        Console.WriteLine("Ongeldige invoer, geen jaartal.");
                    }
                }

                int temp1 = Convert.ToInt32(number1);
                int temp2 = Convert.ToInt32(number2);
                int temp3 = Convert.ToInt32(year);

                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                if (currentDate.Year - temp3 <= 18)
                {
                    if (currentDate.Month <= temp2)
                    {
                        if (currentDate.Month == temp2)
                        {
                            if (currentDate.Day < temp1)
                            {
                                Console.WriteLine($"Resultaat: jonger dan 18!");
                            }
                            else
                            {
                                Console.WriteLine($"Resultaat: 18+");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Resultaat: jonger dan 18!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Resultaat: 18+");
                    }
                }
                else
                {
                    Console.WriteLine($"Resultaat: 18+");
                }
            }
        }
        else
        {
            Console.WriteLine("Ongeldige operatie.");
        }

        
        Console.WriteLine("Wilt u doorgaan? (ja/nee)");
        
        //Stopt de loop als het antwoord niet ja is.
        if (Console.ReadLine().ToLower() != "ja") break;
        
         
    }

    static void plus(double number1, double number2)
    {
        Console.WriteLine($"Resultaat: {number1} + {number2} = " + (number1+number2));
    }
    
    static void keer(double number1, double number2)
    {
        Console.WriteLine($"Resultaat: {number1} * {number2} = " + (number1 * number2));
    }

    static void gedeeld(double number1, double number2)
    {
        if (number2 != 0)
        {
            Console.WriteLine($"Resultaat: {number1} / {number2} = " + number1/number2);
        }
        else
        {
            Console.WriteLine("Delen door nul is niet toegestaan.");
        }
    }

    static void modulo(double number1, double number2)
    {
        Console.WriteLine($"Resultaat: {number1} % {number2} = " + (number1%number2));
    }
    
    static void ouderDan18(double number1, double number2)
    {
        Console.WriteLine($"Resultaat: {number1} % {number2} = " + (number1%number2));
    }
    
    static void sqrt(double number1, double number2)
    {
        double temp = Math.Sqrt(number1) + Math.Sqrt(number2);
        Console.WriteLine($"Resultaat: √{number1} = " + temp);
    }
}