namespace csproject;
public class Day3_Program8
{
    ~Day3_Program8()
    {
        Console.WriteLine("Day3_Program8 : Destructor called");
    }

    static void ClassDestructor()
    {
        Console.WriteLine("check the constructor & destructor");
        for (int i = 0; i < 5; i++)
        {
            Initial3 test1 = new(i);
            //GC.Collect(); // clean the unhandlables 
        }
    }

    static void Main(string[] args) { ClassDestructor(); GC.Collect(); }
}

class Initial3
{
    int state;
    public Initial3(int a)
    {
        state = a;
        Console.WriteLine("Initial : param {0}", state);
    }

    ~Initial3()
    {
        Console.WriteLine("Destructor called: {0}", state);
    }
}