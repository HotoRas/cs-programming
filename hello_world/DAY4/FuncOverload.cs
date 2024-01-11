namespace csproject;
public class Day2_Program29
{
    static int Plus(int x, int y)
    {
        return x + y;
    }
    static float Plus(float x, float y)
    {
        return x + y;
    }
    static double Plus(double x, double y)
    {
        return x + y;
    }

    static void FuncOverload()
    {
        int x = 10, y = 20;
        double d = 10.111;
        Console.WriteLine("sum:");
        Console.WriteLine($"result: intager -> {Plus(x, y)}, double: {Plus(x, d)}");
    }
}