namespace Learning;
public class Bicycle
{
    public enum Sloten
    {
        None, // 0
        Sleutel, // 1
        WielSlot, // 2
        DubbeleSlot, // 3
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
    
    private int _FrameHoogteCm;
    public Sloten Slot { get; set; }
    public Kleuren Kleur { get; set; }

    public Bicycle(Sloten slot, Kleuren kleur, int frameHoogteCm)
    {
        this.Slot = slot;
        this.Kleur = kleur;
        _FrameHoogteCm = frameHoogteCm;
    }

    public override string ToString()
    {
        return $"Slot: {Slot}\nKleur: {kleur}\nFramehoogte(cm): {_FrameHoogteCm}";
    }


    public void PrintVariables()
    {
        ToString();
    }
}