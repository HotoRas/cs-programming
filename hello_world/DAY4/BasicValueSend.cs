namespace csproject;
public class Day2_Program22
{
    static void BasicValSend()
    {
        int x = 10, y = 5;
        Swap(x, y);
        Console.WriteLine($"after swap: external: {x}, {y}");
    }
    static void Swap(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"after swap: internal: {x}, {y}");
    }
}