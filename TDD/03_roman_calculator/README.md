# TDD - C Sharp

Roman Calculator in C#.

## Prerequisites

- [Git](https://github.com/)
- [.Net Core](https://dotnet.microsoft.com/en-us/download/)
- [VS Code](https://code.visualstudio.com/)
  - [LiveShare (Optional)](https://code.visualstudio.com/learn/collaboration/live-share)

## Recommended Visual Studio Code Extensions

- C# for Visual Studio Code (powered by OmniSharp)
- Test Explorer for .NET Core (MSTest, xUnit, NUnit)


# Kata Roman Calculator

[Kata Roman Calculator: Coding Dojo](https://codingdojo.org/kata/RomanCalculator/)

## Problem Description

“As a Roman Bookkeeper I want to add Roman numbers because doing it manually is too tedious.” Given the Roman numerals, (IVXLCDM which means one, five, ten, fifty, hundred, fivehundred and a thousand respectively), create two numbers and add them. As we are in Rome there is no such thing as decimals or int, we need to do this with the strings. An example would be “XIV” + “LX” = “LXXIV”

**There are some rules to a Roman number:**

- Numerals can be concatenated to form a larger numeral (“XX” + “II” = “XXII”)
- If a lesser numeral is put before a bigger it means subtraction of the lesser from the bigger (“IV” means four, “CM” means nine hundred)
- If the numeral is I, X or C you can’t have more than three (“II” + “II” = “IV”)
- If the numeral is V, L or D you can’t have more than one (“D” + “D” = “M”)

**Clues**

String grouping and concatenation is key to solving this kata. But, remember the rule that lesser numerals can precede bigger ones.


# Run

Project created using dotnet cli

## In the termal build and run TypeScript file

```bash
~ dotnet test
```

---

![](/assets/dev3l-solutions-logo-lean-dog.png)
