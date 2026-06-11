using System;
using System.Collections.Generic;
using System.Linq;
using Homework8App.FileWorker;

namespace Homework8App;

internal class FileWorkerDemo
{
    public static void Run()
    {
        Console.WriteLine("=== FileWorker Demo ===");
        Console.WriteLine("1. Test TextFileWorker");
        Console.WriteLine("2. Test JsonFileWorker");

        int choice = InputHelper.GetInt("Choose: ");

        if (choice == 1)
            TestTextFileWorker();
        else if (choice == 2)
            TestJsonFileWorker();
        else
            Console.WriteLine("Invalid choice.");
    }

    private static void TestTextFileWorker()
    {
        long maxSize = InputHelper.GetLong("Max file size (bytes): ");
        var worker = new TextFileWorker(maxSize);
        string fileName = InputHelper.GetString("File name (no extension): ");

        while (true)
        {
            Console.WriteLine("\nTextFileWorker:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Edit");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Back");

            int option = InputHelper.GetInt("Choose: ");

            try
            {
                switch (option)
                {
                    case 1:
                        worker.Write(fileName, InputHelper.GetMultiline("Enter content (END to finish):"));
                        Console.WriteLine("Written!");
                        break;
                    case 2:
                        Console.WriteLine($"\nFile content:\n{worker.Read(fileName)}");
                        break;
                    case 3:
                        worker.Edit(fileName, InputHelper.GetMultiline("New content (END to finish):"));
                        Console.WriteLine("Edited!");
                        break;
                    case 4:
                        worker.Delete(fileName);
                        Console.WriteLine("Deleted!");
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    private static void TestJsonFileWorker()
    {
        long maxSize = InputHelper.GetLong("Max file size (bytes): ");
        var worker = new JsonFileWorker(maxSize);
        string fileName = InputHelper.GetString("File name (no extension): ");

        while (true)
        {
            Console.WriteLine("\nJsonFileWorker:");
            Console.WriteLine("1. Write numbers");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Double numbers (LINQ)");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Back");

            int option = InputHelper.GetInt("Choose: ");

            try
            {
                switch (option)
                {
                    case 1:
                        var numbers = InputHelper.GetIntList("Enter numbers (space separated): ");
                        worker.Write(fileName, System.Text.Json.JsonSerializer.Serialize(numbers));
                        Console.WriteLine("Written!");
                        break;
                    case 2:
                        Console.WriteLine($"\nFile content:\n{worker.Read(fileName)}");
                        break;
                    case 3:
                        var existing = System.Text.Json.JsonSerializer.Deserialize<List<int>>(worker.Read(fileName)) ?? new List<int>();
                        var doubled = existing.Select(n => n * 2).ToList();
                        worker.Edit(fileName, System.Text.Json.JsonSerializer.Serialize(doubled));
                        Console.WriteLine("Numbers doubled (LINQ)!");
                        break;
                    case 4:
                        worker.Delete(fileName);
                        Console.WriteLine("Deleted!");
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
