namespace MiniCLI.Core;


// Every Command must provide a name
// and know how to execute itself!
public interface ICommand
{
    string Name { get; }

    void Execute(string[] args);
}