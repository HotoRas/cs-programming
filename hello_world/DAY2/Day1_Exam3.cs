namespace hello_world;

public class Day1_Program17_Exam
{
    static void Exam()
    {
        Console.WriteLine("현재 시간을 입력하세요");
        int.TryParse(Console.ReadLine(), out int hr);
        //int hr = int.Parse(Console.ReadLine());
        // original expected code: not handling NULL so unused
        // int.TryParse() outs 0 when failed to parse

        Console.WriteLine("현재 시간(분)을 입력하세요");
        int.TryParse(Console.ReadLine(), out int min);

        Console.WriteLine("입력할 시간(분)을 입력해주세요");
        int.TryParse(Console.ReadLine(), out int dur);

        min += dur;
        if (min >= 60)
        {
            hr++;
            min -= 60;
        }

        Console.WriteLine($"요리가 완료될 예상 시간은 {hr}시 {min}분입니다.");
    }
}