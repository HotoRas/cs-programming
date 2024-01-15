namespace csproject;
public class Day3_Program6
{
    Day3_Program6()
    {
        Console.WriteLine("Day3_Program6 : Once every generating obj.");
    }

    static void ClassConstructor()
    {
        Console.WriteLine("Checking generator being run");
        Initial test = new();
    }

    // static void Main() { ClassConstructor(); }
}
class Initial
{
    private readonly int number;
    const int number2 = 5;

    public Initial()
    {
        number = 33;
        Console.WriteLine("Initial : Once every generating obj.");
    }
}