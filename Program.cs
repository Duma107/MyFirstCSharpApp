namespace MyFirstCSharpApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, C# Developer!");
        Console.Write("What's your name? ");
        string name = Console.ReadLine() ?? "Friend";
        Console.WriteLine($"Nice to meet you, {name}!");

        // Add age input with validation
        int age = 0;
        bool validAge = false;
        while (!validAge)
        {
            Console.Write("How old are you? ");
            string ageInput = Console.ReadLine() ?? "";
            validAge = int.TryParse(ageInput, out age);
            if (!validAge)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.WriteLine($"So you're {age} years old, {name}. That's great!");

        // Add a simple calculation
        int birthYear = DateTime.Now.Year - age;
        Console.WriteLine($"That means you were born around {birthYear}.");
    }
}
