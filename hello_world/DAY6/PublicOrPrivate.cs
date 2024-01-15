namespace csproject;
public class Day3_Program3
{
    static string adminName = "관리자";
    static void PublicOrPrivate()
    {
        Console.WriteLine("접근 지정자를 구분하자.");

        string? stName = "아저씨";
        GetAdmin std = new();
        std.oldMember1(stName);
        // std.oldMember2(stName); // private member access from outer -> error!
    }
}

public class GetAdmin
{
    public void oldMember1(string? name)
    {
        Console.WriteLine("{0} 선생, 반갑습니다.", name);
    }

    /*private*/
    void oldMember2(string? name)
    {
        Console.WriteLine("{0} 선생, 반갑습네다.", name);
    }
}