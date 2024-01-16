namespace csproject;
public class Day3_Program12
{
    static void Subclass()
    {
        Univercity univ = new();
        univ.Print();
        Univercity.Department dep = new();
        dep.Print();
    }
}

public class Univercity
{
    public void Print() { Console.WriteLine("성결대학교"); }
    public class Department
    {
        public void Print() { Console.WriteLine("미디어소프트웨어학과"); }
    }
}