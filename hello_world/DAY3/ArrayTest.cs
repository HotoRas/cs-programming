namespace csproject;
public class Day2_Program12_Exam
{
    static void ArrayTest()
    {
        int[] donuts = [4, 6, 11, 55, 34, 9, 12, 2, 1, 32,]; // c-style int[] object declare

        Console.WriteLine("dim: {0}, len: {1}", donuts.Rank, donuts.Length);
        Console.WriteLine("minimum: {0}, maximum: {1}", donuts.Min(), donuts.Max());

        Array.Sort(donuts);
        Array.Clear(donuts, 0, 1); Array.Clear(donuts, donuts.Length - 1, 1);

        Console.WriteLine("Sum of leftover: {0}", donuts.Sum()); // IEnumerable<int>.Sum()
    }
}