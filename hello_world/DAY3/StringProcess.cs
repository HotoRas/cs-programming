namespace csproject;

public class Day2_Program14
{
    static void StringProcess()
    {
        string
        msg1 = "문자열 초기화",
        msg2 = msg1 + " " + "afaddDDD";
        string code_msg = @"
        public string ReadFile(string filename){
            if(!string.IsNullOrEmpty(filename)) return File.ReadAllText(filename);
            return string.Empty;
        }
        ";

        Console.WriteLine($"문자열\t 값 출력 1: {msg1}");
        Console.WriteLine($@"문자열\t 값 출력\n2: {msg1}\t");
        Console.WriteLine($"문자열 값 출력 3: {code_msg}");
        Console.WriteLine($"문자열 길이: {code_msg.Length} 대소문자 {msg2.ToUpper()}");
    }
}