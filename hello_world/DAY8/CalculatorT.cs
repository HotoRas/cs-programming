namespace Calculator2;

public partial class Calculator
{
    public bool MenuLoop()
    {
        Console.WriteLine("계산기: 1. 숫자 입력  2. 더하기  3. 빼기  4. 곱셈  5. 종료");
        if (!int.TryParse(Console.ReadLine(), out int choice)) return true;
        switch (choice)
        {
            case 1:
                {
                    InputValue();
                }
                break;
            case 2:
            case 3:
            case 4:
                {
                    PrintValue(choice);
                }
                break;
            case 5:
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                }
                return false;
            default: break;
        }
        return true;
    }
    int[]? input;
    public Calculator()
    {
        input = null;
    }
    ~Calculator() { input = null; }
}

public class Program
{
    /*
    static void Main()
    {
        ObjectInit calculator = new(new Calculator());
        calculator.Run();
    }
    //*/
}

class ObjectInit
{
    Calculator calc;
    public ObjectInit(Calculator calc)
    {
        this.calc = calc;
    }
    public void Run()
    {
        while (calc.MenuLoop())
        {
            Console.WriteLine();
            GC.Collect(); // run GC every single loop
        }
    }
}

public partial class Calculator
{
    void InputValue()
    {
        Console.Write("인자를 몇 개 입력하시겠습니까?");
        if (!int.TryParse(Console.ReadLine(), out int count) || count < 0)
        {
            Console.WriteLine("인자의 개수를 인식하지 못했습니다. 0개로 설정합니다.");
            input = null; return;
        }
        if (count == 0)
        {
            Console.WriteLine("0개로 설정합니다.");
            input = null; return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine();
            do
            {
                Console.WriteLine($"{i}번째 변수 입력:");
            } while (!int.TryParse(Console.ReadLine(), out input[i]));
        }
    }

    void PrintValue(int choice)
    {
        if (input is null)
        {
            Console.WriteLine("입력이 비어 있습니다. 1번 메뉴에서 다시 설정해주세요.");
            return;
        }

        Console.WriteLine("계산 결과를 출력합니다:");
        Console.Write("입력한 인자값 ");
        switch (choice)
        {
            case 2:
                {
                    Console.WriteLine("더한 결과: {0}", input.Sum());
                }
                break;
            case 3:
                {
                    int sub = input[0];
                    foreach (int i in input[1..]) sub -= i;
                    Console.WriteLine("뺀 결과: {0}", sub);
                }
                break;
            case 4:
                {
                    long mul = 1;
                    foreach (int i in input) mul *= i;
                    Console.WriteLine("곱한 결과: {0}", mul);
                }
                break;
        }
    }
}