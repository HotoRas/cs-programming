namespace csproject;
public class Day3_Program13
{
    static void AccessSubclass()
    {
        Univercity2.Department outin = new();
        // Univercity.Department.PrintDepart();
        outin.PrintDepart();
    }
}

public class Univercity2
{
    private int pass = 123123;
    public void PrintUniv(int a)
    {
        Console.WriteLine("성결대학교 | {0}", a);
    }
    public class Department
    {
        public void PrintDepart()
        {
            Univercity2 inout = new();
            inout.PrintUniv(123123);
            inout.pass = 455788;
            Console.WriteLine("override: {0}", inout.pass);
        }
    }
}