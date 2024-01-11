namespace csproject;
public class Day2_Program27
{
    static int Factorial(int num = 0, int total = 1)
    {
        if (num == 0) return total;

        Console.WriteLine("Called value: {0}", num);
        return Factorial(num - 1, num + total); // recursive call: call self
    }

    static void SelfCallRecursive()
    {
        Console.Write("Intager?  ");
        int.TryParse(Console.ReadLine(), out int n);
        Console.WriteLine("Result: {0}", Factorial(n));
    }
}