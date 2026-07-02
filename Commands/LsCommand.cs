using MiniCLI.Core;

namespace MiniCLI.Commands;

public class LsCommand : ICommand
{
    public string Name => "ls";

    public void Execute(string[] args)
    {
        // Get the current working directory...
        string currentDirectory = Directory.GetCurrentDirectory();

        // Retrieve all folders and files.
        string[] directories = Directory.GetDirectories(currentDirectory);
        string[] files = Directory.GetFiles(currentDirectory);

        // Print each folder name.
        foreach (string directory in directories)
        {
            Console.WriteLine(Path.GetFileName(directory));
        }

        // Print each file name.
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}