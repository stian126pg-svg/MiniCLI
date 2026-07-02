# MiniCLI v1.0

A simple command-line application written in C# that recreates the functionality of several common Unix/Linux terminal commands.

This project was developed as part of a programming assignment with the goal of learning how common CLI tools work "under the hood", while also practicing object-oriented design, file handling, and reusable code.

---

## Features

The following commands have been implemented:

| Command | Description |
|---------|-------------|
| `pwd` | Displays the current working directory. |
| `echo` | Prints text to the terminal. |
| `ls` | Lists files and directories in the current directory. |
| `cat` | Prints the contents of a file. |
| `head` | Displays the first five lines of a file. |
| `tail` | Displays the last five lines of a file. |

---

## Project Structure

The project is organized into separate components to keep responsibilities clear.

```
MiniCLI
│
├── Commands
│   ├── CatCommand.cs
│   ├── EchoCommand.cs
│   ├── HeadCommand.cs
│   ├── LsCommand.cs
│   ├── PwdCommand.cs
│   └── TailCommand.cs
│
├── Core
│   ├── ICommand.cs
│   ├── CommandParser.cs
│   └── CommandRegistry.cs
│
└── Program.cs
```

### Program.cs

The application's entry point. It parses the user's input, looks up the requested command, and executes it.

### ICommand

An interface that defines the structure every command must follow. Each command provides:

- A command name
- An `Execute()` method

### CommandRegistry

Stores all available commands in a dictionary and allows commands to be retrieved by name.

### CommandParser

Separates the command name from any arguments supplied by the user.

### Commands

Each CLI command is implemented as its own class. This keeps the code modular, reusable, and easy to extend.

---

## Example Usage

Display the current directory:

```bash
dotnet run pwd
```

Print text:

```bash
dotnet run echo Hello, World!
```

List files:

```bash
dotnet run ls
```

Display a file:

```bash
dotnet run cat Program.cs
```

Display the first five lines:

```bash
dotnet run head Program.cs
```

Display the last five lines:

```bash
dotnet run tail Program.cs
```

---

## What I Learned

This project helped me practice and understand quite a few things! But chief among them:

- Object-Oriented Programming (OOP)
- Interfaces
- Separation of concerns
- Working with the .NET file system (`File`, `Directory`, and `Path`)
- Parsing command-line arguments
- Organizing code into reusable classes
- Using dictionaries for command lookup

One of the biggest takeaways from this project was seeing how separating each command into its own class makes the application easier to understand, maintain, and extend.

---

## Future Improvements

Possible additions include:

- `touch`
- `cp`
- `mv`
- `rm`
- `wc`
- Support for command options and flags
- Better error handling
- Optional directory/file arguments for commands like `ls`
