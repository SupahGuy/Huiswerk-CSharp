namespace Learning;

public class Person
{
    private static int _instanceCounter;
    private int _persoonNummer;
    
    public Person()
    {
        _persoonNummer = InstanceCount();
    }

    //verhoogd _instanceCounter per Instance wat gemaakt wordt omdat dit in de constructor wordt aangeroepen.
    public int InstanceCount()
    {
        _instanceCounter++;
        return _instanceCounter;
    }

    //Gebruikt om te laten zien welke persoon welke count heeft.
    public override string ToString()
    {
        return $"Persoon Nr: {_persoonNummer} Persoon Count: {_instanceCounter}";
    }
}