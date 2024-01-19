namespace metahuman2;
class Day4_Program11_Exam
{
    static void Run()
    {
        WonderWoman wonderwoman = new();
    }
}

public class MetaHuman
{
    public virtual void skill_1()
    {
        Console.WriteLine("채찍으로 공격합니다.");
    }
    public virtual void skill_2()
    {
        Console.WriteLine("방패로 공격을 막습니다.");
    }
}
public class WonderWoman : MetaHuman
{
    override
    public void skill_1()
    {
        Console.WriteLine("불꽃 채찍으로 공격합니다.");
    }

    override sealed
    public void skill_2()
    {
        Console.WriteLine("방패로 공격을 비껴냅니다.");
    }
}