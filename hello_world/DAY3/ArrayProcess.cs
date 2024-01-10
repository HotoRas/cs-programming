namespace csproject;

public class Day2_Program10
{
    static void ArrayProcess()
    {
        int[] reading = new[] { 4, 9, 1, 5, 21, 12, 55, };
        Console.WriteLine("Rank: {0}, Length: {1}", reading.Rank, reading.Length);

        Array.Clear(reading, 0, 4);
        foreach (int i in reading)
            Console.WriteLine("Array data after purge: {0}", i);

        Array.Resize(ref reading, reading.Length - 5);
        Array.Sort(reading);
        foreach (int i in reading)
            Console.WriteLine("Array data after resizing & sort: {0}", i);
    }
}