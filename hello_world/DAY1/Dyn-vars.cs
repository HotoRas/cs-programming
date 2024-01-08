namespace hello_world;

public class DAY1_Program6
{
    public static void PrintValue(dynamic val)
    {
        Console.WriteLine(val.GetType());
    }
    public DAY1_Program6()
    {
        dynamic st_end/*, st_end2*/;
        // Console.WriteLine("Data value: {0}, type: {1}",st_end,st_end.GetType()); // Unassigned (CS0165)
        st_end = 100;
        // st_end2 = null; // non-nullable variable (CS8600)
        Console.WriteLine("Data value: {0}, type: {1}", st_end, st_end.GetType());
        st_end = 1.1; // type override enabled
        Console.WriteLine("Data value: {0}, type: {1}", st_end, st_end.GetType());
        st_end = "hello";
        Console.WriteLine("Data value: {0}, type: {1}", st_end, st_end.GetType());

        PrintValue("HelloWorld!");
        PrintValue(1000);
        PrintValue(10.50);
    }
}