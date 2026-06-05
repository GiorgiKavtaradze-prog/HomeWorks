using System;

namespace Homework2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) Set console background color to Blue
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear(); // Apply background color to the entire console
            Console.ForegroundColor = ConsoleColor.White;

            // 2) Print first name and last name
            Console.WriteLine("Full Name: Trae AI Assistant");
            Console.WriteLine();

            // 4) Get user input and print it back
            Console.Write("Please enter some text: ");
            string? userInput = Console.ReadLine();

            Console.WriteLine($"You entered: {userInput}");

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            // Console.ReadKey(); 
        }
    }
}
