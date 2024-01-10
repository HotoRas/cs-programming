namespace csproject;

public class Day2_Program9
{
    static void ArrayIO()
    {
        Console.Write("Creating intager array: size: ");
        int.TryParse(Console.ReadLine(), out int cnt);

        int[] numbers = new int[cnt];

        for (int i = 0; i < cnt; i++)
        {
            Console.Write($"Data #{i}: ");
            int.TryParse(Console.ReadLine(), out numbers[i]);
        }

        int avg = 0;
        foreach (int i in numbers)
        {
            avg += i;
            Console.WriteLine($"data: {i}");
        }

        try
        { Console.WriteLine($"average: {avg / cnt}"); }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Array size is 0");
        }
    }
}