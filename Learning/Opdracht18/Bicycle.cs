namespace Learning;
public class Bicycle
{
    public enum Sloten
    {
        Sleutel, // 0
        WielSlot, // 1
        DubbeleSlot, // 2
    }
    public enum Kleuren
    {
        None = -1,
        Red = 0,
        Blue = 1,
        Green = 2,
        NeonBlue = 3,
        Camel = 4,
        Black = 5,
        Orange = 6,
    }

    public enum FietsTypes
    {
        Standaard,
        Elektrisch
    }
    
    private int _frameHoogteCm;
    private Sloten _slot { get; set; }
    private Kleuren _kleur { get; set; }
    private string _locked { get; set; }
    private FietsTypes _fietsType { get; set; }
    private double _rangeInKm { get; set; }

    
    public Bicycle(Sloten slot, Kleuren kleur, int frameHoogteCm, FietsTypes fietsType)
    {
        this._slot = slot;
        this._kleur = kleur;
        _frameHoogteCm = frameHoogteCm;
        _locked = "Unlocked";
        _fietsType = fietsType;
        _rangeInKm = -1; // -1 = unset.
    }

    //De output van de Bicycle klasse
    public override string ToString()
    {
        return $"Slot: {_slot}\nKleur: {_kleur}\nFramehoogte(cm): {_frameHoogteCm}\nSlot Status: {_locked}\nFietstype: {_fietsType}\nKm: {_rangeInKm}\n";
    }

    //Sluit de vergrendeling als deze ontgrendeld is.
    public void Lock()
    {
        if (_locked.Equals("Unlocked")) _locked = "Locked" ;

    }

    //Ontgrendeld de vergrendeling als deze vergendeld is.
    public void Unlock()
    {
        if (_locked.Equals("Locked")) _locked = "Unlocked";
    }

    public void RangeInKm(double rangeKm)
    {
        _rangeInKm = rangeKm;
    }
    
    //Veranderd rangeMiles naar km zodat het in _rangeInKm gedaan kan worden om uitgeprint te worden.
    public void RangeInMiles(double rangeMiles)
    {
        _rangeInKm = (1/0.621371192)*rangeMiles;
    }
}