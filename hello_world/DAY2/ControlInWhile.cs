namespace csproject;

public class Day2_Program3
{
    static void ControlInWhile()
    {
        int input = 0;
        while (true)
        {
            Console.WriteLine("while+switch문을 테스트합니다.");
            Console.WriteLine("메뉴 번호를 입력해주세요.");
            Console.WriteLine("1. 출력 테스트\t2. 프로그램 종료");
            int.TryParse(Console.ReadLine(), out input);

            switch (input)
            {
                case 1:
                    Console.WriteLine("안녕하세요, 홍길동님 반갑습니다."); break;
                case 2:
                    Console.WriteLine("프로그램을 종료합니다..."); break;
                default: break;
            }
            if (input == 2) break;
        }
    }
}