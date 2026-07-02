using MiniCLI.Core;

namespace MiniCLI.Commands;

public class CatCommand : ICommand
{
    public string Name => "cat";

    public void Execute(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: cat <filename>");
            return;
        }

        string fileName = args[0];

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found.");
            return;
        }

        string content = File.ReadAllText(fileName);

        Console.WriteLine(content);
    }
}