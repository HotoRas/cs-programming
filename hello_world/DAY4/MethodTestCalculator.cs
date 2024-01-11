using System.ComponentModel;

namespace Calculator;
public class Day2_Program21_Exam
{
    /// <summary>
    /// Initial program start
    /// </summary>
    static bool ProgramStart()
    {
        Console.WriteLine("How much numbers you're to enter?");
        int.TryParse(Console.ReadLine(), out int count);

        int[] args = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"data {i}: ");
            int.TryParse(Console.ReadLine(), out args[i]);
        }

        bool reset = false;
        while (!reset)
        {
            Console.WriteLine("Calculator menu: 1. Add, 2. Sub, 3. Re-enter numbers, 4. Exit");
            int.TryParse(Console.ReadLine(), out int menu);
            switch (menu)
            {
                case 1:
                    Console.WriteLine($"sum: {Add(args)}");
                    break;
                case 2:
                    Console.WriteLine($"multiplies: {Mul(args)}");
                    break;

                case 3:
                    reset = true;
                    break;
                case 4:
                    return false;
                default: break;
            }
        }
        return true;
    }

    /// <summary>
    /// Add all the args
    /// </summary>
    /// <param name="args">int args to add</param>
    /// <returns>the sum</returns>
    static int Add(params int[] args)
    {
        int sum = 0; // base for sums
        foreach (int i in args) sum += i;
        return sum;
    }

    /// <summary>
    /// Multiplies all the args
    /// </summary>
    /// <param name="args">int args to multiply</param>
    /// <returns>the multiple</returns>
    static int Mul(params int[] args)
    {
        int mul = 1; // base for multiplies
        foreach (int i in args) mul *= i;
        return mul;
    }

    static void Main() { while (ProgramStart()) { } }
}