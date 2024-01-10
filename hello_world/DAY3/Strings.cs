namespace csproject;

public class Day2_Program13
{
    static void Strings()
    {
        string
        message1 = "문자열 초기화",
        message_null = string.Empty,
        message_start = "문자열의 시작부터 ",
        message_end = "끝까지!";

        Console.WriteLine($"문자열\t 값 출력 1: {message1}");
        Console.WriteLine($"문자열 값 '출력 2': {message_start + message_end}");

        int num = 15;
        string message3 = string.Format("숫자 --> 문자{0}", num);
        Console.WriteLine("문자열 변환 출력 3: {0}", message3);

        string time = string.Format("It is now {0:d} at {0:t}", DateTime.Now);
        string price = string.Format("Price is {0:C}", 512123123);

        Console.WriteLine("문자열 변환 출력 4:");
        Console.WriteLine($"{price}\n{time}");

        Console.WriteLine($"문자열\t 값 출력 5: {Math.PI}");
        Console.WriteLine($"문자열\t 값 출력 5: {Math.PI.ToString()}"); // IDE0071: Interpolation can be simplified
    }
}