// Application starter/runner. This is where the magic begins!

using MiniCLI.Core;

// Create a registry containing every available command.
var registry = new CommandRegistry();

// Split the user's input into a command and it's arguments!
var (commandName, arguments) = CommandParser.Parse(args);

// Stop if no command was entered.
if (string.IsNullOrWhiteSpace(commandName))
{
    Console.WriteLine("No command specified.");
    return;
}

// Find and execute the requested command.
if (registry.TryGetCommand(commandName, out var command))
{
    command!.Execute(arguments);
}
else
{
    // Inform the user if the command doesn't exist/isn't in use.
    Console.WriteLine($"Unknown command: {commandName}");
}