namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM5
{
    static void ForInWhile()
    {
        Console.WriteLine("중첩 반복문을 테스트합니다. 수 2개를 연속으로 입력하세요 : ");
        int input1 = Convert.ToInt32(Console.ReadLine());
        int input2 = Convert.ToInt32(Console.ReadLine());
        while (true)
        { // 무조건 실행
            Console.WriteLine("while문 반복 : {0}", input1); // 반복문 밖
            for (int x = 1; x <= input2;)
            {
                Console.WriteLine("for문 반복 : {0}", x); // 반복문 안쪽
                x++; // 증감연산자
                input2 += x; // input2에 1부터 반복까지 수 누적합
                if (input2 > 10)
                {
                    Console.WriteLine("for문 종료");
                    break; // 반복문 종료
                }
            }

            if (input2 > 15)
            {
                Console.WriteLine("while문 종료");
                break; // 반복문 종료
            }

            input1--; // while 문 증감연산자
        }
    }
}
