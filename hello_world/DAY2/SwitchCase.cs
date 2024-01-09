namespace hello_world;
public class Day1_Program15
{
    static void SwitchCase()
    {
        Console.WriteLine("당신의 C# 학점 등급은?");
        char.TryParse(Console.ReadLine().ToUpper(), out char grade);
        // warn: string? Console.ReadLine() could be NULL, but using non-null function string.ToUpper()
        switch (grade)
        {
            case 'A':
                Console.WriteLine("1등입니다. 축하합니다."); break;
            case 'B':
                Console.WriteLine("매우 잘했습니다. 축하합니다."); break;
            case 'C':
                Console.WriteLine("휴, 겨우 해냈어요! 축하합니다."); break;
            case 'D':
            case 'x':
            case 'd':
                Console.WriteLine("다시 봐요.."); break;
            default:
                Console.WriteLine("정확한 학점을 입력해주세요."); break;
        }
    }
}