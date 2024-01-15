namespace csproject;
public class Day2_Program26
{
    static int Factorial(int num = 0)
    {
        if (num == 0) return 0;

        Console.WriteLine("Called value: {0}", num);
        return num + Factorial(num - 1); // recursive call: call self
    }

    static void SelfCallRecursive()
    {
        Console.Write("Intager?  ");
        int.TryParse(Console.ReadLine(), out int n);
        Console.WriteLine("Result: {0}", Factorial(n));
    }
}

// 15925~