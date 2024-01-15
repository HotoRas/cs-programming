namespace csproject;

public class Day2_Program8
{
    static void Arrays()
    {
        int[] num1 = { 1, 2, 3, 5, 10, 50, 20, };
        int[] num_size = new int[5] { 1, 2, 4, 6, 8, };
        int[] num2 = new[] { 6, 8, };

        num_size[1] = 100;
        num_size[0] += 100;

        string[] weekDays = new[] { "Sun", "Mon", "Tue", };

        int count = 1;
        for (int i = 0; i < num_size.Length; i++)
        {
            Console.WriteLine("Test array print: {0}", num_size[i]);
            Console.WriteLine("Test array printout (inv.): {0}", num_size[^count]);
            count++;
        }

        foreach (var num_str in num1)
        {
            Console.WriteLine("foreach: Test array printout: {0}", num_str);
            // Console.WriteLine("foreach: Test array printout: {0}", weekDays[num_str]);
        }

        foreach (var tmp in num_size.Reverse())
        {
            Console.WriteLine("foreach: Test array printout (List.Reverse()): {0}", tmp);
        }
    }
}