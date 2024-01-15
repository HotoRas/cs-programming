namespace hello_world;

public class Day1_Program16
{
    static void SwitchIf()
    {
        Console.WriteLine("당신의 C# 학점은?");
        int.TryParse(Console.ReadLine(), out int a);

        Console.WriteLine("당신의 C# 학점 등급은?");
        char.TryParse(Console.ReadLine().ToUpper(), out char grade);

        switch (grade)
        {
            case 'A':
                if (a >= 90)
                {
                    Console.WriteLine("{0}점입니다. 축하합니다.", a);
                    Console.WriteLine("등급은 {0}입니다. 축하합니다.", grade);
                }
                else Console.WriteLine("학점과 등급이 일치하지 않습니다.");
                break;
            default:
                Console.WriteLine("90점 이상이 합격입니다. 다음 기회에..");
                break;
        }
    }
}