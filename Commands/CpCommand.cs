using MiniCLI.Core;

namespace MiniCLI.Commands;

public class CpCommand : ICommand
{
    public string Name => "cp";

    public void Execute(string[] args)
    {
        // Did the user provide filenames?
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: cp <source> <destination>");
            return;
        }

        string sourceFile = args[0];
        string destinationFile = args[1];

        // Make sure the source file exists!
        if (!File.Exists(sourceFile))
        {
            Console.WriteLine($"Source file '{sourceFile}' not found.");
            return;
        }

        // Prevention accidentally overwriting another file.
        if (File.Exists(destinationFile))
        {
            Console.WriteLine($"Destination file '{destinationFile}' already exists.");
            return;
        }

        // Copy the file.
        File.Copy(sourceFile, destinationFile);

        // Inform the user.
        Console.WriteLine($"Copied '{sourceFile}' to '{destinationFile}'.");
    }
}