using MiniCLI.Core;

namespace MiniCLI.Commands;

public class TailCommand : ICommand
{
    public string Name => "tail";
    
    public void Execute(string[] args)
    {
        // Did the user provide filename?
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: tail <filename>");
            return;
        }

        string fileName = args[0];

        // Make sure file exists!
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found.");
            return;
        }

        // Read every line into an array.
        string[] lines = File.ReadAllLines(fileName);

        // Decide how many lines to print.
        int numberOfLines = Math.Min(5, lines.Length);

        // Find where the last lines begin!
        int start = lines.Length - numberOfLines;

        // Print from the starting point to the end.
        for (int i = start; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}