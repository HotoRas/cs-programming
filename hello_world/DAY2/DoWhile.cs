namespace csproject;
public class Day2_Program2
{
    static void DoWhile()
    {
        Console.Write("do-while문을 테스트합니다. 수 한 개를 입력하세요: ");
        int.TryParse(Console.ReadLine(), out int input);
        do
        {
            Console.WriteLine("반복 {0}", input);
            input++;
        } while (input < 10);

        Console.Write("do-while문을 다시 테스트합니다. 수 한 개를 입력하세요: ");
        int.TryParse(Console.ReadLine(), out input);
        do
        {
            input--;
            if (input % 2 == 0) continue;
            if (input < 0) break;
            Console.WriteLine("반복 {0}", input);
        } while (input < 10);
    }
}