namespace csproject;
public class Day2_Program23
{
    static void RefValSend()
    {
        int x = 10, y = 5;
        Swap(ref x, ref y); // should pass ref kw to send stack ref.
        Console.WriteLine($"after swap: external: {x}, {y}");
    }
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"after swap: internal: {x}, {y}");
    }
}