namespace Learning;

public class Opdracht8
{
    public static void Run()
    {
        int i = 0;
        while (i < 50)
        {
            i++;
            if (i % 3 == 0) continue; // als i deelbaar is door 3 continue loop
            Console.WriteLine(i);
        }
    }
}