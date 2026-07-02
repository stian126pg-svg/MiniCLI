using MiniCLI.Core;

namespace MiniCLI.Commands;

public class LsCommand : ICommand
{
    public string Name => "ls";

    public void Execute(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        string[] directories = Directory.GetDirectories(currentDirectory);
        string[] files = Directory.GetFiles(currentDirectory);

        foreach (string directory in directories)
        {
            Console.WriteLine(Path.GetFileName(directory));
        }

        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}