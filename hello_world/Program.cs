using hello_world2;

namespace hello_world;

class Program
{
    static void Main(string[] args)
    {
        string man = "아저씨"; // string === System.String
        Console.WriteLine("Hello, World!\n{0}", man);
        var temp = new hello_world2.DAY1_Program1(args);
    }
}
