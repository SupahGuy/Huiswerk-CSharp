namespace Learning;

public class Opdracht17_5
{
    private string[] _discountCodes = new string[]
    {
        "P5CQV", "MVFHC", "P1WVX", "H15QA", "CKWX2", "B45SO", "1VRFH", "KSVQO", "WH83H", "AOZMT", "DSTCH", "VQ1H6",
        "C03GB", "1N9YM", "8W7F8"
    };

    private HashSet<string> _discountCodesContainer;
    private HashSet<string> _gebruikteCodes; 
    
    //HashSet lijkt het beste want de QR code moet uniek zijn. 

    public Opdracht17_5()
    {
        _gebruikteCodes = new HashSet<string>();
        _discountCodesContainer = new HashSet<string>();
        DataToHashSet();
    }

    public void Run()
    {
        while (true)
        {
            System.Console.WriteLine("voer code in om geldigheid te checken");
            string userCode = Convert.ToString(Console.ReadLine());

            if (CheckCodeGeldigHeid(userCode))
            {
                System.Console.WriteLine("Wilt u deze code gebruiken? 1=ja, 2=nee");
                int inputCodeGebruiken = Convert.ToInt32(Console.ReadLine());

                if (inputCodeGebruiken == 1) GebruikCode(userCode);
            }
        }
    }
    

    //returnt true als code geldig is
    public bool CheckCodeGeldigHeid(string userInputCode)
    {
        bool isCodeBruikbaar = true;
        bool isCodeGeldig = false;
        
        //bestaat de code?
        foreach (string discountCode in _discountCodesContainer)
        {
            if (discountCode == userInputCode)
            {
                isCodeGeldig = true;
            }
        }
        
        //Is de code al gebruikt?
        foreach (string gebruikteCode in _gebruikteCodes)
        {
            if (userInputCode == gebruikteCode)
            {
                isCodeBruikbaar = false;
            }
        }
        
        if (isCodeGeldig == false)
        {
            System.Console.WriteLine("Geldigheid: Ongeldig");
            return false;
        }
        if (!isCodeBruikbaar)
        {
            System.Console.WriteLine("Ongeldig: Code is al gebruikt!");
            return false;
        }
        System.Console.WriteLine("Geldigheid: Code is Geldig");
        System.Console.WriteLine("Gebruikt: Code is bruikbaar");
        return true;
    }
    
    //"gebruikt" de code.
    public void GebruikCode(string userInputCode)
    {
        Console.WriteLine("Uw Code is geaccepteerd! Geniet van uw eten.");
        _gebruikteCodes.Add(userInputCode);
    }

    //Doet alle data naar de Container
    public void DataToHashSet()
    {
        foreach (string discountCode in _discountCodes)
        {
            _discountCodesContainer.Add(discountCode);
        }
    }
    
}