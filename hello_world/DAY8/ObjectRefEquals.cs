namespace csproject;
public class Day3_Program20
{
    static void ObjRefEquals()
    {
        Console.WriteLine("check obj. instance");
        Comparison obj1 = new("admin");
        Comparison obj2 = obj1;
        Comparison? obj_null = null;

        if (Object.ReferenceEquals(obj1, obj2))
        {
            Console.WriteLine("obj1 is same as obj2");
        }
        else Console.WriteLine("obj1 is defferent from obj2");

        if (obj_null is null) Console.WriteLine("obj_null is null");
        try
        {
            if (obj1 == obj2) Console.WriteLine("a");
        }
        catch
        {
            Console.WriteLine();
        }
    }

    // static void Main() { ObjRefEquals(); }
}

class Comparison
{
    public string id { get; set; }
    public Comparison(string id)
    {
        this.id = id;
    }
}