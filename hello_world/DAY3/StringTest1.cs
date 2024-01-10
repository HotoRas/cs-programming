namespace csproject;

class Day2_Program17_Exam1
{
    static void StringTest1()
    {
        Console.Write("문자열을 2개 입력해주세요: ");
        string? input = Console.ReadLine();
        if (input == null) // null 처리: 아무 입력도 없는 경우
        {
            Console.WriteLine("Error: No input(s)");
            return;
        }

        string[] in_split = input.Split(' ');
        if (in_split.Length != 2) // 2개가 아닌 경우
        {
            Console.WriteLine("Too {0} arguments: expected 2, input {1}",
                in_split.Length < 2 ? "little" : "many", in_split.Length);
            return;
        }

        foreach (var s in in_split) // 근데 코드는 1개여도 1000000개여도 처리 가능
        {
            bool result = true;
            if (!(s.Length == 4 || s.Length == 6)) result &= false;
            result &= int.TryParse(s, out int trial);
            Console.WriteLine("{0}의 문자열 길이 및 숫자 포함 검사 결과: {1}", s, result);
        }
    }
}