namespace csproject;
public class Day3_Program4
{
    static void GetSetMethod()
    {
        Console.WriteLine();

        string stName = "아저씨";
        Admin_2 std = new();

        std.set(516555);
        std.set(stName);
        Console.WriteLine("out: {0}; {1}", std.getInfo1(), std.getInfo2());
    }
}

class Admin_2
{
    private string info1 = "기밀정보";
    int info2 = 901122;

    public string getInfo1() { return info1; }
    public int getInfo2() { return info2; }

    public void set(string val) { info1 = val; }
    public void set(int num) { info2 = num; }
}