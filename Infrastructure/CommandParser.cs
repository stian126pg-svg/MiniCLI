namespace MiniCLI.Core;

public static class CommandParser
{
    public static (string Command, string[] Args) Parse(string[] args)
    {
        // No input means no command.
        if (args.Length == 0)
            return ("", []);

        // First argument is the command.
        // Everything after it becomes command arguments.
        return (args[0], args.Skip(1).ToArray());
    }
}