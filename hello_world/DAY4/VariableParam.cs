namespace csproject;
public class Day2_Program21
{
    static void VariableParam()
    {
        int a = 3, b = 6, c = 7;
        ParamsPractice(new int[] { a, b, c });
        int[] arr = ParamsPractice(a, b, c);

        Console.WriteLine("Test params kwarg: simple arr. print");
        foreach (var i in arr) Console.WriteLine(i);
    }
    public static int[] ParamsPractice(params int[] array)
    {
        return array;
    }
}