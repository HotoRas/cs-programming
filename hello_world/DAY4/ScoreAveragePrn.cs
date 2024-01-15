namespace csproject;
public class Day2_Program30
{
    static void MenuLoop()
    {
        string?[] name = [];
        int[] score = [];

        while (true)
        {
            Console.WriteLine("Please select the menu: 1. Enter score, 2. Print score, 3. Exit");
            int.TryParse(Console.ReadLine(), out int menu);
            switch (menu)
            {
                case 1:
                    InputScore(ref name, ref score);
                    break;
                case 2:
                    PrintScore(ref name, ref score);
                    break;
                case 3:
                    return;
                default: break;
            }
        }
    }

    static void InputScore(ref string?[] name, ref int[] score)
    {
        Console.WriteLine("Enter students' names and scores:");

        Console.Write("Student count: ");
        int.TryParse(Console.ReadLine(), out int count);
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

    static void PrintScore(ref string?[] name, ref int[] score)
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
}