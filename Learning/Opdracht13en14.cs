namespace Learning;

public class Opdracht13en14
{

    public static void Run()
    {
        Console.WriteLine("tot hoeveel moet de FizzBuzz Algoritme gaan?");
        int userInputNummer = Convert.ToInt32(Console.ReadLine());
        
        FizzBuzzBang(userInputNummer);

    }


    public static void FizzBuzzBang(int userInputNummer)
    {
        for (int i = 1; userInputNummer >= i; i++)
        {
            //reset elke iteratie fizzBuzz variabel
            string fizzBuzz = "";

            //voegt het toe aan fizzBuzz variabel zodat er makkelijke maintenance is.
            if (CheckDeelbaar(i, 3))
            {
                fizzBuzz += "fizz";
            }
            if (CheckDeelbaar(i, 5))
            {
                fizzBuzz += "buzz";
            }
            if (CheckDeelbaar(i, 7))
            {
                fizzBuzz += "bang";
            }

            //Als de fizzbuzz string niet leeg is, print het iets fizzBuzz variabel, anders de nummer.
            if (fizzBuzz != "")
            {
                Console.WriteLine(fizzBuzz);
            }
            else
            {
                // i+1 zodat het start bij 1.
                Console.WriteLine(i);
            }
        }
    }


    //checket ofdat i deelbaar is door j (alleen natuurlijke getallen)
    public static bool CheckDeelbaar(int i, int j)
    {
        if (i % j == 0)
        {
            return true;
        }
        //returnt false als het niet true returnt, geen else statement nodig want anders zou het al true hebben gereturnet.
        return false;
    }
}