# TDD - C Sharp

'Hello, World!' to demostrate C# language features.


## Prerequisites

- [Git](https://github.com/)
- [.Net Core](https://dotnet.microsoft.com/en-us/download/)
- [VS Code](https://code.visualstudio.com/)
  - [LiveShare (Optional)](https://code.visualstudio.com/learn/collaboration/live-share)

## Recommended Visual Studio Code Extensions

- C# for Visual Studio Code (powered by OmniSharp)


# Setup

Project created dotnet cli

```bash
~ cd HelloWorld
~ dotnet new console
```

## In the termal build and run TypeScript file

```bash
~ cd HelloWorld
~ dotnet run
```


# VSCode Runtime Configuration

```json
{
    "version": "0.2.0",
    "configurations": [
        {
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            "program": "${workspaceFolder}/bin/Debug/net6.0/HelloWorld.dll",
            "args": [],
            "cwd": "${workspaceFolder}",
            "console": "internalConsole",
            "stopAtEntry": false
        },
        {
            "name": ".NET Core Attach",
            "type": "coreclr",
            "request": "attach"
        }
    ]
}

```

---

![](/assets/dev3l-solutions-logo-lean-dog.png)


