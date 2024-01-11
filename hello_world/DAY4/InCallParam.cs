namespace csproject;
public class Day2_Program25
{
    static void InCall()
    {
        int roArg = 44;
        InArgExample(roArg);
    }
    static void InArgExample(in int number)
    {
        Console.WriteLine("In argument: {0}", number);
        // number = 19; // ERROR CS8331
    }
}