# TDD - C Sharp

'Hello, World!' to demostrate C# language features.


## Prerequisites

- [Git](https://github.com/)
- [.Net Core](https://dotnet.microsoft.com/en-us/download/)
- [VS Code](https://code.visualstudio.com/)
  - [LiveShare (Optional)](https://code.visualstudio.com/learn/collaboration/live-share)

## Recommended Visual Studio Code Extensions

- C# for Visual Studio Code (powered by OmniSharp)
- Test Explorer for .NET Core (MSTest, xUnit, NUnit)


# Run

Project created using dotnet cli

## In the termal build and run TypeScript file

```bash
~ dotnet run
```


# Visual Studio Code - Code Coverage

1. Add Extension: .NET Core Test Explorer
  - `"dotnet-test-explorer.testProjectPath": "**/**Tests.csproj"`
  - `"dotnet-test-explorer.testArguments": "--collect:\"XPlat Code Coverage\""`

2. Add Extension: Coverage Gutters
  - `"coverage-gutters.showLineCoverage": true`
  - `"coverage-gutters.coverageFileNames": ["coverage.cobertura.xml"]`

  
---

![](/assets/dev3l-solutions-logo-lean-dog.png)


