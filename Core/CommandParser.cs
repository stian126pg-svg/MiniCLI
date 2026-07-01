namespace MiniCLI.Core;

public static class CommandParser
{
    public static (string Command, string[] Args) Parse(string[] args)
    {
        if (args.Length == 0)
            return ("", []);

        return (args[0], args.Skip(1).ToArray());
    }
}