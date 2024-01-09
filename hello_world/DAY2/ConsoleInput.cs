namespace hello_world;

public
class Day1_Program8
{
    public Day1_Program8()
    {
        Console.WriteLine("Enter your age: ");
        int age = Console.Read();
        Console.WriteLine("Your age is: " + age);

        // flush:
        Console.ReadLine();

        Console.WriteLine("Enter your birth: ");
        int birth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your birth is: " + birth);

        Console.WriteLine("Press any key to continue...\n");
        Console.ReadKey();
        // ERROR on default VSCode setting:
        // Cannot read keys when either application does not have a console or when console input has been redirected.

        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Your name is: " + name);
    }
}