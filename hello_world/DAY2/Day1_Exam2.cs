namespace hello_world;

public class Day1_Program13_Exam
{
    static void Exam()
    {
        int a, b;
        Console.Write("첫 번째 변수를 입력해주세요: ");
        int.TryParse(Console.ReadLine(), out a);
        Console.Write("두 번째 변수를 입력해주세요: ");
        int.TryParse(Console.ReadLine(), out b);

        Console.WriteLine("사칙 연산 결과 -> 더하기: {0}; 빼기: {1}; 곱하기: {2}; 나누기: {3}; 나머지: {4}", a + b, a - b, a * b, a / b, a % b);
    }

    static void Main() { Exam(); }
}