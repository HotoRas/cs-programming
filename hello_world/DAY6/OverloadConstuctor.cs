namespace csproject;
public class Day3_Program7
{
    static void OverloadConstructor()
    {
        Console.WriteLine("Checking constructor call");
        Initial2
            test1 = new(),
            test2 = new(4),
            test3 = new(100, "홍길동");
    }
}

public class Initial2
{
    static Initial2()
    {
        Console.WriteLine("should be run on class load");
    }

    public Initial2()
    {
        Console.WriteLine("Initial: No arg(s).");
    }

    public Initial2(int a)
    {
        Console.WriteLine("Initial: got intager");
    }

    public Initial2(int a, string n)
    {
        Console.WriteLine("Initial: got intager and string");
    }
}