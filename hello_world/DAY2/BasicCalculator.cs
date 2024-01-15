namespace hello_world;

public class Day1_Program11
{
    public static void BasicCalculator()
    {
        int
        x = 10,
        y = 3;
        double
        x2 = 10,
        y2 = 3.14;

        int
        result1 = x + y,
        result2 = x - y,
        result3 = x * y;
        double
        result4 = x / y;

        double
        result5 = y / x,
        result6 = x % y,
        result7 = y % x;

        Console.WriteLine("a와 b의 연산 결과 (정수):");
        Console.WriteLine($"sum: {result1}, sub: {result2}, mul: {result3}, sub: {result4} {result5}, div: {result6} {result7}");

        Console.WriteLine("a와 b의 연산 결과 (실수):");
        Console.WriteLine($"sub: {x2 / y2}, div: {x % y}");

        Console.WriteLine("a와 b의 연산 결과 (정수, 실수):");
        Console.WriteLine($"mul: {x * y2}");
    }
}