namespace csproject;
public class Day2_Program7_Exam1
{
    static void Exam1()
    {
        int a, b;
        while (true)
        {
            Console.WriteLine("두 수를 입력하세요:");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            if (a == 0 && b == 0) break;
            Console.WriteLine($"두 수의 합: {a} + {b} = {a + b}");
        }
        Console.WriteLine("프로그램을 종료합니다.");
    }
}

public class Day2_Program7_Exam2
{
    static void Exam2()
    {
        const string Pass = "123123";
        for (int trys = 0; ;)
        {
            Console.Write("Password (trys: {0}/5): ", trys);
            string? answer = Console.ReadLine();

            if (answer == Pass)
            {
                Console.WriteLine("Successfully logged in!");
                break;
            }
            if (answer == null)
            {
                Console.WriteLine("Please enter a password!");
            }
            else if (answer.Length < 6 || answer.Length > 9)
            {
                Console.WriteLine("Login failed! (length: 6~9, in: {0})", answer.Length);
            }
            Console.WriteLine("Login failed! Tries: {0}/5", ++trys);
            if (trys >= 5)
            {
                Console.WriteLine("Login failed! Please try again later.");
                break;
            }
            /*
// 그냥 이런 것도 된다는
if(answer.Length<6||anser.Length>9){
Console.WriteLine("Login failed! (length: 6~9, input: {0})", answer.Length);
trys++;
continue;
}
switch(answer){
case Pass:
Console.WriteLine("Successfully logged in!");
trys=5;
break;
default:
trys++;
break;
}

            */
        }
    }
}