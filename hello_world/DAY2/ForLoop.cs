namespace csproject;
public class Day2_Program4
{
    static void ForLoop()
    {
        // int x = 1; 카운터를 먼저 선언해도 상관없음
        Console.WriteLine("for문을 테스트합니다.수 한개를 입력하세요 : ");
        int input = Convert.ToInt32(Console.ReadLine());
        for (int x = 1; x <= input; x++)
        { // 카운터, 조건식, 연산식
            Console.WriteLine("반복1 {0}", x); // x부터 input까지 반복
            // x++; for문 내부에서 증감연산자도 가능
        }
        // Console.WriteLine("for문에서 사용한 카운터 x의 값 : {0}", x); 출력될까?
        for (int x = 1; x <= input; x += 2)
        { // 산술연산식 가능 : 2씩 증감
            Console.WriteLine("반복2 {0}", x);
        }
        for (int x = 1; x <= input;)
        { // 연산식 생략
            Console.WriteLine("반복3 {0}", x);
            x++; // 코드 내에서 증감연산자 
            if (x == 5)
            { // break문 정지 가능
                break;
            }
        }

        int a = 0;
        for (; ; )
        {
            Console.WriteLine(a++);
            if (a > 30) break;
        }
    }
}