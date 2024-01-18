using System.IO.Compression;
using System.Security.Cryptography;

namespace csproject;
public class Day4_Program2
{
    public string name { get; set; } = "";
    public int age { get; set; } = 0;
    static void Run()
    {
        Bird 새 = new();
        새.age = 20;
        새.name = "훔친새";
        새.Fly();
    }
}
public class Dog : Day4_Program2
{
    public void HowOld() { Console.WriteLine("나이: {0}", age); }
}
public class Bird : Day4_Program2
{
    public void Fly()
    {
        Console.WriteLine("{0}살입니다.", age);
        Console.WriteLine("{0}가 날고 있어요!", name);
    }
}