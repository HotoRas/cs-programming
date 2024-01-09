namespace hello_world;

public class Day1_Program10
{
    static Day1_Program10()
    {
        int i = 100000;
        double
        d = 1.00001,
        e = 1.00001;
        char chr = 'C';
        float flt = .0001f;

        Console.WriteLine($"Data type of {d} before conversion: {d.GetType()}");
        d = i; // int->double
        Console.WriteLine($"Data type of {d} after conversion: {d.GetType()}");

        d = (double)i; // force conv. double -> double
        Console.WriteLine($"Data type of {d} after conversion: {d.GetType()}");

        // i = e; // double -> int // error
        i = (int)e; // force conv. (int)double -> int
        Console.WriteLine($"Invert conversion: {e} -> {i}");

        flt = chr; // char (uint8) -> float
        // chr = flt; // float -> char (uint8) // error
    }
}