namespace csproject;
public class Day2_Program1
{
    static void WhileLoop()
    {
        Console.Write("While문을 테스트합니다. 수 한 개를 입력하세요: ");
        int.TryParse(Console.ReadLine(), out int input);
        while (++input <= 10)
        {
            Console.WriteLine("반복 {0}", input);
        }

        Console.Write("While문을 테스트합니다. 수 한 개를 입력하세요: ");
        int.TryParse(Console.ReadLine(), out input);
        while (input <= 10)
        {
            Console.WriteLine("반복 {0}", input);
            --input;
            if (input < 0) break;
        }
    }
}