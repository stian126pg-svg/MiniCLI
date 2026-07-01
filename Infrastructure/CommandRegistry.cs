using MiniCLI.Commands;

namespace MiniCLI.Core;

public class CommandRegistry
{
    private readonly Dictionary<string, ICommand> _commands = new();

    public CommandRegistry()
    {
        Register(new PwdCommand());
        Register(new EchoCommand());
    }

    private void Register(ICommand command)
    {
        _commands.Add(command.Name, command);
    }

    public bool TryGetCommand(string name, out ICommand? command)
    {
        return _commands.TryGetValue(name, out command);
    }
}