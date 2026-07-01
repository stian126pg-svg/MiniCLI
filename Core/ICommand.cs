namespace MiniCLI.Core;

public interface ICommand
{
    string Name { get; }

    void Execute(string[] args);
}