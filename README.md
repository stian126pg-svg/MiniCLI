# MiniCLI v2.0

A simple command-line application written in C# that recreates several common Unix/Linux CLI commands.

MiniCLI was developed as a learning project to better understand how terminal commands work under the hood while practicing Object-Oriented Programming, file handling, and project organization in C#.

---

## Features

Currently implemented commands:

| Command | Description |
|---------|-------------|
| `pwd` | Display the current working directory. |
| `echo` | Print text to the console. |
| `ls` | List files and directories in the current directory. |
| `cat` | Display the contents of a file. |
| `head` | Display the first five lines of a file. |
| `tail` | Display the last five lines of a file. |
| `touch` | Create a new empty file. |
| `cp` | Copy one file to another. |
| `rm` | Delete a file. |

---

## Project Structure

```
MiniCLI
│
├── Commands
│   ├── CatCommand.cs
│   ├── CpCommand.cs
│   ├── EchoCommand.cs
│   ├── HeadCommand.cs
│   ├── LsCommand.cs
│   ├── PwdCommand.cs
│   ├── RmCommand.cs
│   ├── TailCommand.cs
│   └── TouchCommand.cs
│
├── Core
│   ├── ICommand.cs
│   ├── CommandParser.cs
│   └── CommandRegistry.cs
│
└── Program.cs
```

---

## Design

Rather than placing every command inside a large `switch` statement, each command is implemented as its own class using a shared `ICommand` interface.

The application flow is:

```
Program.cs
      │
      ▼
CommandParser
      │
      ▼
CommandRegistry
      │
      ▼
Selected Command
      │
      ▼
Execute()
```

This makes the project modular, reusable, and easy to extend with additional commands.

---

## Example Usage

```bash
dotnet run pwd
```

```bash
dotnet run ls
```

```bash
dotnet run cat Program.cs
```

```bash
dotnet run head README.md
```

```bash
dotnet run tail README.md
```

```bash
dotnet run touch notes.txt
```

```bash
dotnet run cp notes.txt backup.txt
```

```bash
dotnet run rm notes.txt
```

---

## What I Learned

During this project I practiced:

- Object-Oriented Programming
- Interfaces
- Separation of Concerns
- Command-line argument parsing
- Working with the .NET File API
- Working with the .NET Directory API
- Using dictionaries for fast command lookup
- Structuring projects into reusable components

The biggest takeaway was learning how a modular architecture makes adding new commands simple without changing the application's core logic.

---

## Future Improvements

Potential future additions include:

- `mv`
- `wc`
- `mkdir`
- `rmdir`
- Command options and flags
- Better error handling
- Unit tests
- Configurable line count for `head` and `tail`

---

## Built With

- C#
- .NET 8
- Visual Studio 2022
