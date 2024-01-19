namespace csproject;
class Day4_Program10 : Mother
{
    //protected override void F(){Console.WriteLine("redefined son's money 1");} // CS0239 redifine error
    protected override void F2() { Console.WriteLine("redefined son's modey 2"); }
    static void Run()
    {
        Day4_Program10 son = new();
        son.F();
        son.F2();
        son.get_info1();
        son.get_info2();
    }
    public void get_info2()
    {
        base.F2();
    }
}
class GrandMother
{
    protected virtual void F() { Console.WriteLine("origin: grandmother's money 1"); }
    protected virtual void F2() { Console.WriteLine("origina: grandmother's money 2"); }
}
class Mother : GrandMother
{
    sealed protected override void F() { Console.WriteLine("mother's money 1: limited"); }
    protected override void F2() { Console.WriteLine("redefined: mother's money 2"); }
    public void get_info1()
    {
        base.F2();
    }
}
