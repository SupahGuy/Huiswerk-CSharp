namespace Learning;

public class Opdracht6
{
    public static void Run()
    {
        //print alle namen  uit List namen dat <= 5 karakters in lengte.
        List<string> namen = new List<string> { "Anna", "Bob", "Charlie", "Dave", "Eva", "Frank", "Grace", "Harry", "Ivy", "Jack" };
    
        foreach (var naam in namen)
        {
            if (naam.Length <= 5)
            {
                System.Console.WriteLine(naam);
            }
        }
    }
}