namespace csproject;
public class Day2_Program20
{
    static int Plus(int x = 3, int y = 5) => Day2_Program18.Plus(x, y); // 구현 다시 치기 귀찮다

    static void GetParam()
    {
        int x = 10, y = 5;

        int z1 = Plus(x, y);
        int z2 = Plus();
        int z3 = Plus(5);
        //int z4 = Plus(,5);
        int z4 = Plus(y: 10, x: -3);

        Console.WriteLine("sum: {0}", z1);
        Console.WriteLine("sum: {0}", z2);
        Console.WriteLine("sum: {0}", z3);
        Console.WriteLine("sum: {0}", z4);
    }
}