using MiniCLI.Core;

namespace MiniCLI.Commands;

public class CatCommand : ICommand
{
    public string Name => "cat";

    public void Execute(string[] args)
    {
        // Did user provide filename?
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: cat <filename>");
            return;
        }

        string fileName = args[0];

        // Make sure file exists!
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found.");
            return;
        }

        // Read the entire file into one string.
        string content = File.ReadAllText(fileName);

        // Display the file contents.
        Console.WriteLine(content);
    }
}