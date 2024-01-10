using System.Numerics;

namespace csproject;

public class Day2_Program16
{
    static void StringComp()
    {
        string m1, m3;
        m1 = m3 = "오늘은 정말 배아파요!";
        string m2 = "오늘은 정말 배가 불러요?";
        string m4 = "HELLO_WORLD!";
        string m5 = "hello world!";

        Console.WriteLine($"문자열 비교 1 : {string.Equals(m1, m3)}");
        Console.WriteLine($"문자열 비교 2: {m1 == m3}");
        Console.WriteLine($"문자열 비교 3: {string.Compare(m1, m3)}");
        Console.WriteLine($"문자열 비교 4: {string.Compare(m1, m2)}");

        Console.WriteLine($"문자열 비교 5: {m4 == m5}");
        Console.WriteLine($"문자열 비교 6: {m4.Equals(m5, StringComparison.OrdinalIgnoreCase)}"); // ignore the cases

        string m_null1 = "",
            m_null2 = " ",
            m_null3 = "\n";

        Console.WriteLine($"null? : {string.IsNullOrEmpty(m_null1)}"); // string? null or string.Empty()
        Console.WriteLine($"null? : {string.IsNullOrEmpty(m_null2)}"); // if spaces?
        Console.WriteLine($"null? : {string.IsNullOrWhiteSpace(m_null2)}"); // spaces are now null
        Console.WriteLine($"null? : {string.IsNullOrEmpty(m_null3)}"); // if \n (breakline)?
    }
}