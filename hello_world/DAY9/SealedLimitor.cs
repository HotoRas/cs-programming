namespace csproject;
public class Day4_Program7
{
    static void Run()
    {
        Sub_Program sw = new();
        // sw.init();
        sw.start();
    }
}
sealed class Main_Program
{
    public void init()
    {
        Console.WriteLine("top class");
    }
}
public class Sub_Program/*: Main_Program*/ // error
{
    public void start()
    {
        Console.WriteLine("start");
    }
}