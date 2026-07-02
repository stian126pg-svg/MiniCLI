using MiniCLI.Core;

namespace MiniCLI.Commands;

public class EchoCommand : ICommand
{
    public string Name => "echo";

    public void Execute(string[] args)
    {
        // Print every argument as one sentence.
        Console.WriteLine(string.Join(" ", args));
    }
}