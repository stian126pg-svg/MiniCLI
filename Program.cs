// Application starter/runner. This is where the magic begins!

using MiniCLI.Core;

var registry = new CommandRegistry();

var (commandName, arguments) = CommandParser.Parse(args);

if (string.IsNullOrWhiteSpace(commandName))
{
    Console.WriteLine("No command specified.");
    return;
}

if (registry.TryGetCommand(commandName, out var command))
{
    command!.Execute(arguments);
}
else
{
    Console.WriteLine($"Unknown command: {commandName}");
}