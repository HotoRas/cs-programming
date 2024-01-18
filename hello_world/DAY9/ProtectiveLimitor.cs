namespace csproject;
public class Day4_Program6
{
    static void Run()
    {
        SubProgram3 sw = new();
        //sw.init();
        sw.start();
    }
}
public class MainProgram3
{
    protected int protected_check1 = 15;
    protected static int protected_check2 = 15;
    protected void init()
    {
        Console.WriteLine("프로그램의 최상위 클래스입니다.");
    }
}
public class SubProgram3 : MainProgram3
{
    Day4_Program6 test = new();
    int temp = protected_check2 = 15;
    public void start()
    {
        int temp = base.protected_check1 + 1;
        init();
        Console.WriteLine("프로그램을 시작합니다...");
    }
}