namespace hello_world; // entire file below this line is in namespace hello_world

public
class DAY1_Program2
{
    public DAY1_Program2() // generator
    {
        VarTypes();
    }
    static void VarTypes() // private func.
    {
        int myNum;
        myNum = 5;
        double myDouble = 5.99d;
        char myLtr = 'D';
        bool myBool = true;
        string myTxt = "Hello";

        Console.Write(myNum);
        Console.WriteLine(); // Console.Write('\n');
        Console.WriteLine(myDouble);
        Console.WriteLine(myLtr);
        Console.WriteLine(myBool);
        Console.WriteLine(myTxt);
    }
}