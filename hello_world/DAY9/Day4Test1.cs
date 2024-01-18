namespace Day4Test1;
public class Day4_Program8_Exam1
{
    static void Run()
    {
        //todo
    }
}

public class Human
{
    protected string Name = "a";
    protected int Age = 20;
    protected int Height = 160;

    public void Eat() { Console.WriteLine($"{Name} eats"); }
    public void Walk() { Console.WriteLine($"{Name} walks"); }
}
public class Teacher : Human
{
    string subject = "void";
    public void Teach() { Console.WriteLine($"{Name}teaches {subject}"); }
    public void Study() { Console.WriteLine($"{Name} is learning {subject}"); }
}
public class Student : Human
{
    string sclass = "void";
    public void Learn() { Console.WriteLine($"{Name} learns in {sclass}"); }
    public void Academy() { Console.WriteLine($"{Name} walks to academy"); }
}
public class Worker : Human
{
    string Team = "void";
    public void Work() { Console.WriteLine($"{Name} works on {Team}"); }
    public void GoWork() { Console.WriteLine($"{Name} goes for a work"); }
}