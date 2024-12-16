namespace Learning;

//gemaakt door chatGPT

public class VariablePlus
{
    // Declare 'i' as a class-level variable
    private static int i = 0;

    public static void Run()
    {
        variablePlus(); // Call the method that increments i

        Console.WriteLine("i: " + i); // Print the updated value of i
    }

    static void variablePlus()
    {
        i++; // Increment the class-level variable
    }
}