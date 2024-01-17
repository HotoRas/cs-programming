namespace csproject;
public class Day3_Program17
{
    static void HaveShalCopied()
    {
        Console.WriteLine("if not have copy generator -> inserte each istance");
        Persons person1 = new("홍길동", 20);
        Persons person2 = new(person1.name, person1.age);
        //etc
        Console.WriteLine(person1.St_Prn());
        Console.WriteLine(person2.St_Prn());
    }

    // static void Main() { HaveShalCopied(); }
}

class Persons
{
    public string name { get; set; }
    public int age { get; set; }
    public Persons(string name, int age) { this.name = name; this.age = age; }
    public string St_Prn() { return "이름: " + name + ", 나이: " + age; }
}