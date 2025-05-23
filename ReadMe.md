# MyFirstCSharpApp

This is a simple C# console application to demonstrate basic programming concepts.

## Description

MyFirstCSharpApp is a beginner-friendly console application built with C# and .NET. The program greets the user, asks for their name, and responds with a personalized message.

## Features

- Greets the user.
- Asks for the user's name and age.
- Calculates the user's birth year.
- Provides null-safe handling with the null-coalescing operator
- Demonstrates string interpolation

## Getting Started

### Prerequisites

- .NET SDK (version 6.0 or later)

### Installation

1. Clone the repository or download the source code:
   ```
   git clone https://github.com/yourusername/MyFirstCSharpApp.git
   ```
   
2. Navigate to the project directory:
   ```
   cd MyFirstCSharpApp
   ```

### Running the Application

Build and run the application using the .NET CLI:

```bash
dotnet run
```

## Code Overview

```csharp
Console.WriteLine("Hello, C# Developer!");
Console.Write("What's your name? ");
string name = Console.ReadLine() ?? "Friend";
Console.WriteLine($"Nice to meet you, {name}!");
```

The application:
1. Greets the user with "Hello, C# Developer!"
2. Prompts the user to enter their name
3. Reads the user's input, defaulting to "Friend" if null
4. Outputs a personalized greeting using string interpolation

## Screenshots
![Screenshot 1](Screenshots/Screenshot%202025-04-09%20111345.png)
![Screenshot 2](Screenshots/Screenshot%202025-04-09%20171830.png)
![Screenshot 3](Screenshots/Screenshot%202025-04-09%20205649.png)

## Collaboration Request

**Important Note for Joseph Monakedi:**
- Please run this program on your system
- Enter your name when prompted
- Take a screenshot of your terminal showing the program's execution and output
- Upload the screenshot to the project's "screenshots" directory via GitHub as part of our collaboration
- This will help document different environments where the program has been successfully tested

## Learning Points

- `Console.WriteLine()` - Outputs text with a line break at the end
- `Console.Write()` - Outputs text without a line break
- `Console.ReadLine()` - Reads user input as a string
- `??` - The null-coalescing operator, which provides a default value if the left side is null
- `$"..."` - String interpolation for embedding variables within strings

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgments

- Created as part of learning C# and .NET console applications
- Thanks to the .NET community for excellent documentation and resources
- Special thanks to Reitumetse M & Joseph M for collaboration and testing
