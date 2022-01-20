# TDD - C Sharp

Fizz Buzz in C#.

## Prerequisites

- [Git](https://github.com/)
- [.Net Core](https://dotnet.microsoft.com/en-us/download/)
- [VS Code](https://code.visualstudio.com/)

## Recommended Visual Studio Code Extensions

- C#
- .NET Core Test Explorer
- Coverage Gutters
- LiveShare


# Fizz Buzz

[Fizz Buzz: Coding Dojo](http://codingdojo.org/kata/FizzBuzz)

## Problem Description

Write a program that returns a list of numbers and strings from 1 to n, where n is the upper bound.

- For multiples of three set “Fizz” instead of the number
- For the multiples of five set “Buzz”
- For numbers which are multiples of both three and five set “FizzBuzz“
- Otherwise set the ordinal number

**Upper bound**: 15 <br/>
**Example output**: [1, 2, 'Fizz', 4, 'Buzz', 'Fizz', 7, 8, 'Fizz', 'Buzz', 11, 'Fizz', 13, 14, 'FizzBuzz']


# Run

Project created using dotnet cli

## In the termal build and run TypeScript file

```bash
~ dotnet test
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
