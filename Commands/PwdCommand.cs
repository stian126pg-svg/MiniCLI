using MiniCLI.Core;

namespace MiniCLI.Commands;

public class PwdCommand : ICommand
{
    public string Name => "pwd";

    public void Execute(string[] args)
    {
        // Print the current working directory.
        Console.WriteLine(Directory.GetCurrentDirectory());
    }
}