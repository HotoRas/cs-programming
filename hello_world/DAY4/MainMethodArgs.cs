namespace csproject;
public class Day2_Program19
{
    static void MainDay2Prog19(string[] args)
    {
        int cArgs = args.Length;

        if (cArgs < 2)
        {
            PrnInfo();
            return;
        }

        string inputFile = args[0],
            outputFile = args[1];

        Console.WriteLine($"In File: {inputFile}, Out File: {outputFile}");
    }

    static void PrnInfo()
    {
        Console.WriteLine("Usage: {0} <inputFileName> <outputFileName>", AppDomain.CurrentDomain.FriendlyName);
        Console.WriteLine("Example:");
        Console.WriteLine($"\t{AppDomain.CurrentDomain.FriendlyName} data.inp data.out");
    }
}