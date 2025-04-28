# MiF.Guard  

MiF.Guard is a .NET library that implements the Guard pattern, enabling concise and effective validation of inputs and business rules. By reducing boilerplate code and improving readability, it helps developers enforce constraints and handle invalid states gracefully in their applications.

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
