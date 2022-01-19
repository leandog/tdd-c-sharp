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
# $NODE = which node
{
  "version": "0.2.0",
  "configurations": [
    {
      "type": "node",
      "request": "launch",
      "name": "Launch Program",
      "program": "${workspaceFolder}/hello_world.ts",
      "outFiles": ["${workspaceFolder}/dist/**/*.js"],
      "runtimeExecutable": "$NODE"
    }
  ]
}

```

---

![](/assets/dev3l-solutions-logo-lean-dog.png)


