using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework4App;

public static class ContactManager
{
    private static Dictionary<string, string> contacts = new Dictionary<string, string>();

    public static void Run()
    {
        while (true)
        {
            ShowMenu();
            
            string choice = Console.ReadLine() ?? string.Empty;
            
            if (choice == "5")
            {
                break;
            }
            
            ProcessChoice(choice);
            
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    private static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("=== CONTACT MANAGER ===");
        Console.WriteLine();
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. Delete Contact");
        Console.WriteLine("3. Update Contact");
        Console.WriteLine("4. Show All Contacts");
        Console.WriteLine("5. Exit");
        Console.WriteLine();
        Console.WriteLine($"Total Contacts: {contacts.Count}");
        Console.Write("Choose an option: ");
    }

    private static void ProcessChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                AddContact();
                break;
            case "2":
                DeleteContact();
                break;
            case "3":
                UpdateContact();
                break;
            case "4":
                ShowContacts();
                break;
        }
    }

    private static void AddContact()
    {
        Console.WriteLine("\n--- ADD CONTACT ---");
        
        Console.Write("Enter name: ");
        string name = Console.ReadLine() ?? string.Empty;
        
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty!");
            return;
        }
        
        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("This contact already exists!");
            return;
        }
        
        Console.Write("Enter phone: ");
        string phone = Console.ReadLine() ?? string.Empty;
        
        if (string.IsNullOrWhiteSpace(phone))
        {
            Console.WriteLine("Phone cannot be empty!");
            return;
        }
        
        contacts.Add(name, phone);
        Console.WriteLine("Contact added successfully!");
    }

    private static void DeleteContact()
    {
        Console.WriteLine("\n--- DELETE CONTACT ---");
        
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts to delete!");
            return;
        }
        
        Console.Write("Enter name to delete: ");
        string name = Console.ReadLine() ?? string.Empty;
        
        if (contacts.Remove(name))
        {
            Console.WriteLine("Contact deleted!");
        }
        else
        {
            Console.WriteLine("Contact not found!");
        }
    }

    private static void UpdateContact()
    {
        Console.WriteLine("\n--- UPDATE CONTACT ---");
        
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts to update!");
            return;
        }
        
        Console.Write("Enter name to update: ");
        string name = Console.ReadLine() ?? string.Empty;
        
        if (!contacts.ContainsKey(name))
        {
            Console.WriteLine("Contact not found!");
            return;
        }
        
        Console.WriteLine("Current phone: " + contacts[name]);
        Console.Write("Enter new phone: ");
        string newPhone = Console.ReadLine() ?? string.Empty;
        
        if (string.IsNullOrWhiteSpace(newPhone))
        {
            Console.WriteLine("Phone cannot be empty!");
            return;
        }
        
        contacts[name] = newPhone;
        Console.WriteLine("Contact updated!");
    }

    private static void ShowContacts()
    {
        Console.WriteLine("\n--- ALL CONTACTS ---");
        
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts!");
            return;
        }
        
        Console.WriteLine();
        foreach (var contact in contacts.OrderBy(c => c.Key))
        {
            Console.WriteLine($"{contact.Key} - {contact.Value}");
        }
    }
}
