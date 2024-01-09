using System.Globalization;

namespace csproject;
public class Day2_Program6
{
    static void ForEach()
    {
        int[] num = { 1, 2, 3, 5, 10, 15, 20, };
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda", };

        Console.WriteLine("Testing foreach");

        foreach (int i in num) Console.WriteLine("data: {0}", i);
        foreach (string i in cars.Reverse())
            Console.WriteLine("data: {0}", i);
    }
}