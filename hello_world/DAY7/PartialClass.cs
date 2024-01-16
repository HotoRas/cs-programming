namespace csproject;
partial class MyClass
{
    public void Method1() { Console.WriteLine("call 1st partial class"); }
}
partial class MyClass
{
    public void Method2() { Console.WriteLine("call 2nd partial class"); }
}
public class Day3_Program14
{
    class Program
    {
        static void PartialClass()
        {
            Console.WriteLine("test partial class");
            MyClass obj = new();
            obj.Method1();
            obj.Method2();
        }
    }
}