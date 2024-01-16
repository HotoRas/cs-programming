namespace csproject;

public class Day3_Program10
{
    static void MethodPerperty()
    {
        Console.WriteLine("get: private data access:");

        string name = "아저씨";
        GetAdmin_3 admin = new();
        Console.WriteLine("print -> {0} {1}", admin.info1_manage, admin.info2_manage);

        admin.info1_manage = name;
        admin.info2_manage = "581823";
        Console.WriteLine("print -> {0} {1}", admin.info1_manage, admin.info2_manage);

        Console.WriteLine(admin.print());
    }
}

class GetAdmin_3
{
    private string
        info1 = "기밀정보",
        info2 = "901122";
    private int property_test { get; set; } = 999999;

    public string info1_manage
    {
        set { info1 = value; }
        get { return info1; }
    }

    public string info2_manage
    {
        set { info2 = value; }
        get { return info2; }
    }

    public int print()
    {
        return property_test;
    }
}