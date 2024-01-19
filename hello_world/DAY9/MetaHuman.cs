namespace metahuman;
public class Day4_Program8_Exam2
{
    static void Run()
    {
        SuperMan superman = new("Superman", 30, 4625, "fly; laser;");
    }
}
public class MetaHuman
{
    public string Name;
    protected string privName;
    protected int Age;
    protected int Power;
    protected string Skill;
}
public class SuperMan : MetaHuman
{
    public SuperMan(string name, int age, int power, string skill)
    {
        privName = "Klerk Kent";
        Name = name;
        Age = age;
        Power = power;
        Skill = skill;
    }
}
