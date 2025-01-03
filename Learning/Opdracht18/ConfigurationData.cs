namespace Learning;

public static class ConfigurationData
{
    private const string _applicatieNaam = "Krokingus";
    private const double _versie = 1.003 ;
    private const int _maxAantalGebruikers = 100;
    
    //Getters voor variabelen ookal kunnen ze al aangeroepen worden en zijn ze readonly...
    public static string Get_applicatieNaam()
    {
        return _applicatieNaam;
    }

    public static double Get_versie()
    {
        return _versie;
    }
    
    public static int Get_maxAantalGebruikers()
    {
        return _maxAantalGebruikers;
    }
}