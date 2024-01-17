namespace csproject;

public class Day3_Program21
{
    static void RemoveObjects()
    {
        Sample? x = new();
        x.value = "some value";
        Console.WriteLine("value before remove: {0}", x.value);
        x = null;
        try
        {
            Console.WriteLine("after insert null: {0}", x.value);
            x.value = "some value 2";
            GC.Collect();
            Console.WriteLine("after GC: {0}", x.value);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("error: null");
            Console.WriteLine(e);
        }
    }
    // static void Main() { RemoveObjects(); }
}

class Sample
{
    public string value { get; set; }
    public Sample()
    {
        value = string.Empty;
    }
}