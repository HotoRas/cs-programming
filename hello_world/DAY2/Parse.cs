namespace hello_world;

public
class Day1_Program9
{
    public Day1_Program9()
    {
        //string ageStr;
        int age;
        int sum;

        Console.WriteLine("Input your age: ");
        // ageStr = Console.ReadLine(); // no conv.
        // sum = ageStr + 1; // error
        age = Convert.ToInt32(Console.ReadLine());
        sum = age + 1;
        Console.WriteLine($"First age is {sum} as added 1");
        Console.WriteLine($"Data type: {sum.GetType()}");

        Console.WriteLine("Input your age: ");
        age = int.Parse(Console.ReadLine()); // nullable -> warn
        sum = age + 1;
        Console.WriteLine($"Second age is {sum} as added 1");
        Console.WriteLine($"Data type: {sum.GetType()}");

        Console.WriteLine("Input your age: ");
        int.TryParse(Console.ReadLine(), out age);
        sum = age + 1;
        Console.WriteLine($"Third age is {sum} as added 1");
        Console.WriteLine($"Data type: {sum.GetType()}");
    }
}