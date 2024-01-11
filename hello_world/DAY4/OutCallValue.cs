namespace csproject;
public class Day2_Program24
{
    static void OutCall()
    {
        int x, y; OutTest(out x, out y); // OutTest(out int x, out int y);
        Console.WriteLine($"value: {x}, {y}");
    }

    static void OutTest(out int x, out int y)
    {
        x = 30; y = 15;
        Console.WriteLine($"value (internal): {x}, {y}");
    }
}