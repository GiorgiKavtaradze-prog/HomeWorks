# Homework 5 — Console Utility Suite

This repository contains Homework5App, a modular .NET 10 console application that implements six distinct tasks. Each task is isolated in its own class and is designed to demonstrate structured input handling, domain-specific processing, and direct console output.

## Project Structure

Main files under Homework5App/:

- Program.cs — application entry point that invokes each task sequentially.
- InputHelper.cs — reusable console input validation and parsing utilities.
- SquareAreaDifferenceCalculator.cs — calculates the area difference between two squares.
- JackpotChecker.cs — checks whether all elements in a sequence are identical.
- FootballPointsCalculator.cs — computes football points from match outcomes.
- EmployeeSalaryCalculator.cs — calculates weekly salary based on daily working hours.
- MarathonProgressCalculator.cs — counts days with progress in a sequence of results.
- ArrayElementLengthFilter.cs — filters array elements by exact string length.

## Requirements

- .NET 10 SDK
- Command-line access
- Supported platforms: Windows, Linux, macOS

## Build and Run

Open a terminal in the `Homework5` directory and run:

```bash
dotnet build Homework5App\Homework5App.csproj
```

Then execute:

```bash
dotnet run --project Homework5App\Homework5App.csproj
```

The application will prompt for input for each task and output the result directly to the console.

## Task Descriptions

### 1. SquareAreaDifferenceCalculator
- Requests a radius value from the user.
- Calculates the larger square area as (2 * radius) * (2 * radius).
- Calculates the smaller square area as 2 * radius * radius.
- Outputs the difference between the two areas.

### 2. JackpotChecker
- Accepts a space-separated list of elements.
- Returns Yes if every element is identical, otherwise No.

### 3. FootballPointsCalculator
- Accepts a space-separated list of match outcomes: win, draw, loss.
- Applies the scoring system: win = 3, draw = 1, loss = 0.
- Outputs the total points earned.

### 4. EmployeeSalaryCalculator
- Requests seven daily work-hour values.
- Calculates regular pay and overtime pay for weekdays.
- Applies double pay for weekend hours.
- Outputs the total weekly salary.

### 5. MarathonProgressCalculator
- Requests the number of days and a corresponding list of scores.
- Counts the number of days where the current score is higher than the previous day.
- Outputs the total progress days.

### 6. ArrayElementLengthFilter
- Requests a target length N.
- Reads a space-separated list of string elements.
- Outputs elements whose length equals N.

## Notes

Homework5App is designed as a concise learning-oriented console application. The modular task implementation makes it easy to maintain, extend, or reuse individual components for future exercises.
