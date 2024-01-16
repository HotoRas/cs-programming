namespace Day3_Program15_Test;

public partial class Student // partial class for login subroutine
{
    bool loggedIn = false;

    /// <summary>
    /// Student management login class
    /// </summary>
    public class Login
    {
        readonly string password = "123123";
        public string Password
        {
            get { return password; }
            // set => password = value; // error: readonly
        }
    }

    /// <summary>
    /// Login to the management service
    /// </summary>
    /// <returns></returns>
    public bool login()
    {
        Console.Write("password: ");
        string? pass = Console.ReadLine();
        return login(pass);
    }
    public bool login(string? password)
    {
        Login member = new();
        loggedIn = member.Password == password;
        return loggedIn;
    }
}

public class Program
{
    static void MenuLoop()
    {
        Student stu = new();
        while (!stu.login()) Console.WriteLine("Password is incorrect!\n");
        while (true)
        {
            Console.WriteLine("Please select the menu: 1. Enter score, 2. Print score, 3. Exit");
            int.TryParse(Console.ReadLine(), out int menu);
            switch (menu)
            {
                case 1:
                    stu.InputScore();
                    break;
                case 2:
                    stu.PrintScore();
                    break;
                case 3:
                    return;
                default: break;
            }
        }
    }
}

/// <summary>
/// Main class for student
/// </summary>
public partial class Student // main routine about student
{
    string?[] name = [];
    int[] score = [];
    int count = 0;

    public void InputScore()
    {
        if (!loggedIn)
        {
            Console.WriteLine("Not logged in!");
            login();
            return;
        }
        Console.WriteLine("Enter students' names and scores:");

        Console.Write("Student count: "); int.TryParse(Console.ReadLine(), out count);
        name = new string?[count];
        score = new int[count];
        string? temp = null;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Name of student {i}: ");
            temp = Console.ReadLine();
            if (temp == null) name[i] = "GUEST";
            else name[i] = temp;
            Console.Write($"Score of student {i}: ");
            temp = Console.ReadLine();
            if (temp == null) score[i] = 0;
            else int.TryParse(temp, out score[i]);
        }

        Console.WriteLine("Finished entering student data.");
    }

    public void PrintScore()
    {
        if (!loggedIn)
        {
            Console.WriteLine("Not logged in!");
            login();
            return;
        }
        if (count < 1)
        {
            Console.WriteLine("Invalid student data. Please enter the data through menu 1.");
            return;
        }
        for (int i = 0; i < count; i++)
            Console.WriteLine($"{i}번째 학생 - 이름: {name[i]}, 점수: {score[i]}");

        Console.WriteLine($"평균: {score.Average()}");
    }
}