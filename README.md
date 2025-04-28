# MiF.Guard

MiF.Guard is a modern and lightweight .NET library designed to implement the Guard pattern, a powerful approach for handling operation outcomes. By encapsulating success and error states, MiF.Guard promotes cleaner, more maintainable code by reducing reliance on exceptions for control flow.  
With MiF.Guard, you can streamline error handling, improve code readability, and ensure robust type safety in your applications. Whether you're building small utilities or large-scale systems, MiF.Guard provides the tools you need to manage operation results effectively.

## Installation
To use MiF.Guard in your project, add it as a dependency via NuGet:

```csharp
dotnet add package MiF.Guard
```

## Usage

```csharp
using MiF.Guard;

string input = "Hello, World!";"
string returnData = Guard.Against.NullOrEmpty(data);

int inputAge = 42;
int returnAge = Guard.Against.GreaterThan(inputAge, 18);

```

## License
This project is licensed under the MIT License. See the LICENSE file for details.
