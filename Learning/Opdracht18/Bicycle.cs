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

    private int _FrameHoogteCm;
    private Sloten _Slot { get; set; }
    private Kleuren _Kleur { get; set; }
    private Boolean _Locked { get; set; }
    private FietsTypes FietsType { get; set; }

    public Bicycle(Sloten slot, Kleuren kleur, int frameHoogteCm)
    {
        this._Slot = slot;
        this._Kleur = kleur;
        _FrameHoogteCm = frameHoogteCm;
        _Locked = false;
    }

    //return
    public override string ToString()
    {
        if (_Locked)
        {
            return $"Slot: {_Slot}\nKleur: {_Kleur}\nFramehoogte(cm): {_FrameHoogteCm}\nSlot Status: Locked\n";
        }
        return $"Slot: {_Slot}\nKleur: {_Kleur}\nFramehoogte(cm): {_FrameHoogteCm}\nSlot Status: Unlocked\n";
    }

    //Sluit de vergrendeling als deze ontgrendeld is.
    public void Lock()
    {
        if (!_Locked) _Locked = true;

    }

    //Ontgrendeld de vergrendeling als deze vergendeld is.
    public void Unlock()
    {
        if (_Locked) _Locked = false;
    }
}