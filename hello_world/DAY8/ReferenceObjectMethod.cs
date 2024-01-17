namespace csproject;

class Day3_Program16
{
    static void objParaSend(Sub_Program1 obj)
    {
        Console.WriteLine("object: {0}", obj);
        Console.WriteLine("value: {0}", obj.state);
        obj.state = "함수 객체 전달 완료";
    }
    static void ReferenceObjectMethod()
    {
        Sub_Program1 main = new();
        main.state = "객체의 값 설정됨";
        Sub_Program1 main2 = new();
        main2 = main;
        objParaSend(main);
        objParaSend(main2);
    }

    // static void Main() { ReferenceObjectMethod(); }
}
class Sub_Program1
{
    public Sub_Program1()
    {
        this.state = "default";
    }
    public string state { get; set; }
}