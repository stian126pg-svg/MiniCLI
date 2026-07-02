using MiniCLI.Commands;

namespace MiniCLI.Core;

public class CommandRegistry
{
    // Stores commands using their name as the key!
    private readonly Dictionary<string, ICommand> _commands = new();

    public CommandRegistry()
    {
        // Register every available command here:
        Register(new PwdCommand());
        Register(new EchoCommand());
        Register(new LsCommand());
        Register(new CatCommand());
        Register(new HeadCommand());
        Register(new TailCommand());
    }

    //Add a Command to the dictionary.
    private void Register(ICommand command)
    {
        _commands.Add(command.Name, command);
    }

    // Find command by it's name. Or try to!
    public bool TryGetCommand(string name, out ICommand? command)
    {
        return _commands.TryGetValue(name, out command);
    }
}