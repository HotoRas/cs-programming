namespace Day3_Program5_Test;
public class Main
{
    // static void Main(string[] args) { MenuLoop(); }
    static void MenuLoop()
    {
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

        for (int i = 0; i < count; i++)
        {
            Console.Write($"{i}번째 학생의 이름: ");
            name[i] = Console.ReadLine();
            Console.Write($"{i}번째 학생의 점수: ");
            int.TryParse(Console.ReadLine(), out score[i]);
        }

        Console.WriteLine("Finished entering student data.");
    }

    public void PrintScore()
    {
        if (name.Length < 1)
        {
            Console.WriteLine("Invalid student data. Please enter the data through menu 1.");
            return;
        }
        for (int i = 0; i < name.Length; i++)
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
}