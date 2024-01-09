namespace hello_world;
public class Day1_Program14
{
    static void IfElse()
    {
        int a, b;

        Console.Write("첫 번째 수 -> ");
        int.TryParse(Console.ReadLine(), out a);
        Console.Write("두 번째 수 -> ");
        int.TryParse(Console.ReadLine(), out b);

        Console.WriteLine($"입력된 두 수: {a}, {b}");

        // if-elif-else: single line doesn't require {}
        if (a > b)
            Console.WriteLine("첫 번째로 입력한 수가 큰 수입니다.");
        else if (a == b)
            Console.WriteLine("입력한 두 수가 같습니다.");
        else Console.WriteLine("두 번째로 입력한 수가 큰 수입니다.");
    }
}