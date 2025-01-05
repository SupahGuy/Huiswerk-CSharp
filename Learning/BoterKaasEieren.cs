namespace Learning;

public class BoterKaasEieren
{

    public static void Run()
    {
        string position1 = "1";
        string position2 = "2";
        string position3 = "3";
        string position4 = "4";
        string position5 = "5";
        string position6 = "6";
        string position7 = "7";
        string position8 = "8";
        string position9 = "9";
        
        while (true)
        {


            System.Console.WriteLine($"{position1} | {position2} | {position3}");
            System.Console.WriteLine("----------");
            System.Console.WriteLine($"{position4} | {position5} | {position6}");
            System.Console.WriteLine("----------");
            System.Console.WriteLine($"{position7} | {position8} | {position9}");
            
            System.Console.WriteLine("Voer nummer in.");
            int inputGebruiker = Convert.ToInt32(System.Console.ReadLine());
            switch (inputGebruiker)
            {
             
                case >=1 and <=9:
                    MakeMove(inputGebruiker);
                    break;
                    
                default: 
                    Console.WriteLine("ongeldige invoer");
                    break;
            }
        }

        void MakeMove(int userInput)
        {
            
        }

    }



}