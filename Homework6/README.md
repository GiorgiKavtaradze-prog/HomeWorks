# Homework 6 — Console Utility Suite

This repository contains Homework6App, a modular .NET 10 console application that implements six distinct tasks. Each task is isolated in its own class and is designed to demonstrate structured input handling, domain-specific processing, and direct console output.

## Project Structure

Main files under Homework6App/:

- Program.cs — application entry point that invokes each task sequentially.
- InputHelper.cs — reusable console input validation and parsing utilities.
- PowerIntervalChecker.cs — calculates count of perfect powers in interval.
- PairsCounter.cs — counts letter pairs in uppercase string.
- LongestCommonSuffixFinder.cs — finds longest common suffix of two strings using LINQ.
- GenericListProcessor.cs — generic list processor for strings, integers, booleans.
- RecursiveDigitPrinter.cs — recursively prints digits separated by " - ".
- DuplicateChecker.cs — checks for duplicate elements in integer array using LINQ.

## Requirements

- .NET 10 SDK
- Command-line access
- Supported platforms: Windows, Linux, macOS

## Build and Run

Open a terminal in the `Homework6` directory and run:

```bash
dotnet build Homework6App\Homework6App.csproj
```

Then execute:

```bash
dotnet run --project Homework6App\Homework6App.csproj
```

The application will prompt for input for each task and output the result directly to the console.

## Task Descriptions

### 1. PowerIntervalChecker
- Requests interval bounds (a, b) and power (n).
- Calculates count of perfect nth powers in [a, b].
- Uses LINQ for clean enumeration.

### 2. PairsCounter
- Accepts a string of letters.
- Counts number of letter pairs (each occurrence of a letter can be in at most one pair).
- Uses LINQ for grouping and summing.

### 3. LongestCommonSuffixFinder
- Accepts two strings.
- Finds longest common suffix using LINQ.
- Uses recursive approach with range reversal.

### 4. GenericListProcessor
- Generic function to handle three list types: strings, integers, booleans.
- String list: prints all elements in uppercase.
- Integer list: calculates and prints sum using LINQ.
- Boolean list: prints first, last, and middle element.

### 5. RecursiveDigitPrinter
- Accepts an integer.
- Recursively builds string of digits separated by " - ".
- Handles negative numbers using absolute value.

### 6. DuplicateChecker
- Accepts space-separated integer array.
- Uses LINQ Distinct() to check for duplicates.
- Outputs true/false in lowercase.

## Notes

Homework6App is designed as a concise learning-oriented console application. The modular task implementation makes it easy to maintain, extend, or reuse individual components for future exercises. All tasks use LINQ where appropriate and follow professional coding practices including separation of concerns and clean, readable code.
