namespace Day3_Program9_Test;
public class Main
{
    // static void Main(string[] args) { MenuLoop(); }

    static bool login()
    {
        string? id = null;
        Console.Write("username: ");
        id = Console.ReadLine();
        if (id == null) return false;

        string? pass = null;
        Console.Write("password: ");
        pass = Console.ReadLine();
        Console.Clear();

        if (StudentManage.checkPassword(pass)) return true;

        Console.WriteLine("Wrong password");
        return false;
    }
    static void MenuLoop()
    {
        while (!login()) ;

        StudentManage student = new();

        while (true)
        {
            Console.WriteLine("Please select the menu: 1. Enter score, 2. Print score, 3. Exit");
            int.TryParse(Console.ReadLine(), out int menu);
            switch (menu)
            {
                case 1:
                    student.InputScore();
                    break;
                case 2:
                    student.PrintScore();
                    break;
                case 3:
                    return;
                default: break;
            }
        }
    }
}
class StudentManage
{
    string?[] name = [];
    int[] score = [];
    int count = 0;

    public void InputScore()
    {
        Console.WriteLine("Enter students' names and scores:");

        Console.Write("Student count: ");
        int.TryParse(Console.ReadLine(), out count);
        name = new string?[count];
        score = new int[count];
        string? temp = null;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"{i}번째 학생의 이름: ");
            temp = Console.ReadLine();
            if (temp == null) name[i] = "GUEST";
            else name[i] = temp;
            Console.Write($"{i}번째 학생의 점수: ");
            temp = Console.ReadLine();
            if (temp == null) score[i] = 0;
            else int.TryParse(temp, out score[i]);
        }

        Console.WriteLine("Finished entering student data.");
    }

    public void PrintScore()
    {
        if (count < 1)
        {
            Console.WriteLine("Invalid student data. Please enter the data through menu 1.");
            return;
        }
        for (int i = 0; i < count; i++)
            Console.WriteLine($"{i}번째 학생 - 이름: {name[i]}, 점수: {score[i]}");

        Console.WriteLine($"평균: {score.Average()}");
    }

    public bool getStudentInfo(int index, out string? name, out int? score)
    {
        if (index >= count)
        {
            name = null; score = null;
            return false;
        }

        name = this.name[index];
        score = this.score[index];
        return true;
    }

    readonly static string password = "123123";

    public static bool checkPassword(string? pass)
    {
        return password == pass;
    }
}