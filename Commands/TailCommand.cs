using MiniCLI.Core;

namespace MiniCLI.Commands;

public class TailCommand : ICommand
{
    public string Name => "tail";

    public void Execute(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: tail <filename>");
            return;
        }

        string fileName = args[0];

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        int numberOfLines = Math.Min(5, lines.Length);

        int start = lines.Length - numberOfLines;

        for (int i = start; i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }
    }
}