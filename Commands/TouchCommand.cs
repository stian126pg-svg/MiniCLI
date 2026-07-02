using MiniCLI.Core;

namespace MiniCLI.Commands;

public class TouchCommand : ICommand
{
    public string Name => "touch";

    public void Execute(string[] args)
    {
        // Did the user provide filename?
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: touch <filename>");
            return;
        }

        string fileName = args[0];

        // Check if file already exists.
        if (File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' already exists.");
            return;
        }

        // Create the file.
        using (File.Create(fileName))
        {
        }

        // Inform the user that the file was created.
        Console.WriteLine($"Created file '{fileName}'.");
    }
}