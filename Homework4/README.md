# Homework4

.NET Console Application with 4 tasks

## Project Description

This project is a .NET Console Application that contains 4 tasks:

1. **Even and Odd Number Filter** - Filter even and odd numbers
2. **Contact Manager** - Contact manager
3. **Element Counter** - Element counter
4. **Top N Largest Numbers** - Select N largest numbers

## Project Structure

```
Homework4/
├── Homework4App/
│   ├── Program.cs              # Main program execution code
│   ├── InputHelper.cs          # Input helper class
│   ├── EvenOddFilter.cs        # Task 1 - Even/odd filter
│   ├── ContactManager.cs       # Task 2 - Contact manager
│   ├── ElementCounter.cs       # Task 3 - Element counter
│   ├── TopNSelector.cs         # Task 4 - N largest numbers
│   └── Homework4App.csproj     # Project configuration
└── Homework4.slnx              # Solution file
```

## Requirements

- .NET 10.0 SDK or newer version

## How to Run

1. Navigate to the project directory:
   ```powershell
   cd Homework4
   ```

2. Build the project:
   ```powershell
   dotnet build
   ```

3. Run the project:
   ```powershell
   dotnet run --project Homework4App
   ```

## Tasks

### Task 1: Even and Odd Number Filter
Enter an array of numbers, the program will filter even and odd numbers.

### Task 2: Contact Manager
Add, delete, update contacts and show all contacts.

### Task 3: Element Counter
Enter an array of numbers, the program will count the number of occurrences of each element and the sum.

### Task 4: Top N Largest Numbers
Enter an array of numbers and a number N, the program will display the N largest numbers.
