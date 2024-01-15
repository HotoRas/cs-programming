namespace csproject;

public class Day2_Program17_Exam2
{
    static void StringTest2()
    {
        string[] name_array = ["아저씨", "김새나", "엄마", "아빠", "누나", "형", "동생", "김말아유", "홍길동", "개구리",];

        Console.Write("이름을 입력합니다: ");
        string? name_input = Console.ReadLine();

        bool found = false;
        int loc = 0;

        foreach (string s in name_array)
        {
            found |= s == name_input;
            if (found) break;
            loc++;
        }

        if (found) Console.WriteLine($"{name_input}의 위치는 {loc}번에 숨어있습니다.");
        else Console.WriteLine($"{name_input}은 존재하지 않습니다.");
    }
}