namespace csproject;

public class Day2_Program15
{
    static void StringMethod()
    {
        string msg1 = "오늘은 정말 '배고픈' 날입니다! HELLO";
        int msg_idx = msg1.IndexOf("HE");

        Console.WriteLine($"string idx: {msg_idx}");
        Console.WriteLine($"chomp 1: {msg1.Substring(msg_idx, 5)}");
        Console.WriteLine($"replace: {msg1.Replace('L', 'l')}");

        string[] msg2 = msg1.Split('\'', ' ');
        foreach (var w in msg2) Console.WriteLine($"chomp 2: {w}");

        string msg3 = "HELLO WORLD!";
        string reversed = new(msg3.Reverse().ToArray());
        Console.WriteLine($"reverse: {reversed}");
    }
}