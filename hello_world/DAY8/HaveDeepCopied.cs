namespace csproject;
public class Day3_Program18
{
    static void objParaSend(SubProgram2 obj)
    {
        Console.WriteLine("object: {0}", obj);
        Console.WriteLine("state: {0}", obj.state);
        obj.state = "object sent";
    }
    static void HaveDeepCopied()
    {
        SubProgram2 main = new();
        SubProgram2 main2 = main.Copy();
        main.state = "set 1st obj. value";
        main2.state = "set 2nd obj. value";
        objParaSend(main);
        objParaSend(main2);
    }

    // static void Main() { HaveDeepCopied(); }
}

public class SubProgram2
{
    public SubProgram2()
    {
        state = "default";
    }
    public SubProgram2 Copy() => (SubProgram2)this.MemberwiseClone(); // gets new object based on called
    public string state { get; set; }
}