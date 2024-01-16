namespace csproject;
public class Day3_Program11
{
    int count = 0;

    public Day3_Program11(int count = 0)
    {
        this.count = count;
        Console.WriteLine("after call: {0}", count);
    }

    public void set_count(int count) { this.count = count; }
    public int get_count() { return this.count; }
}
public class Day3_Program11_exec // execute method to other class
{
    static void KwThis()
    {
        Console.WriteLine("this kwarg -> test");
        Day3_Program11 _main = new(777);
        _main.set_count(666);
        Console.WriteLine("after modifying: {0}", _main.get_count());
    }
}