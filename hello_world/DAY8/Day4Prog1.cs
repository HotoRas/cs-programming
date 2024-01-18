namespace csproject;
public class Day4_Program1
{
    static void Run()
    {
        D4P1Sub sw = new();
        sw.init();
        sw.start();
    }
}

class D4P1Main
{
    public void init() { Console.WriteLine("프로그램의 최상위 클래스입니다"); }
}

class D4P1Sub : D4P1Main
{
    public void start() { Console.WriteLine("start sub prog."); }
    public void stop() { Console.WriteLine("wait a while"); }
    public void attack() { Console.WriteLine("attack"); }
}