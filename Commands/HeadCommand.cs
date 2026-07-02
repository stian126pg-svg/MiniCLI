using MiniCLI.Core;

namespace MiniCLI.Commands;

public class HeadCommand : ICommand
{
    public string Name => "head";

    public void Execute(string[] args)
    {
        // Did user give us a filename?
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: head <filename>");
            return;
        }

        string fileName = args[0];

        // Does the file actually exist?
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found.");
            return;
        }

        // Read every line into an array.
        string[] lines = File.ReadAllLines(fileName);

        // Decide how many lines to print.
        int numberOfLines = Math.Min(5, lines.Length);

        // Print only those lines.
        for (int i = 0; i < numberOfLines; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}