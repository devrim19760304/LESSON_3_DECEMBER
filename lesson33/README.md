
# Lesson 3-3: Exploring Static and Non-Static Methods in C#

## Overview
In this lesson, we studied the differences between **static** methods and **non-static** methods in C#. Here are the key concepts we covered:

- **Static Methods**: These methods can be called directly using the class name without creating an instance of the class.
- **Non-Static Methods**: These methods require an instance of the class to be created before they can be called.

We also worked with practical examples, including income calculations, summation of numbers, and text manipulation.

---

## Methods Covered

### 1. Greeting Method (Non-Static)
- Demonstrates how to use a non-static method by creating an instance of the `Program` class.
- Example usage:
    ```csharp
    Program program = new Program();
    program.Greeting("Your Name");
    ```

### 2. Netto Income Calculator (Static)
- Calculates the monthly and yearly net income after applying a tax rate.
- Example usage:
    ```csharp
    decimal nettoIncome = NettoIncome(34333m, 0.3m);
    Console.WriteLine("Monthly Income: " + nettoIncome);
    ```

### 3. Summation of Numbers (Static)
- Calculates the sum of integers between a start and end value.
- Example usage:
    ```csharp
    SumOfNumbers(0, 200);
    ```

### 4. Reverse Text (Static)
- Reverses a given string and returns the reversed result.
- Example usage:
    ```csharp
    string reversed = reverseText("Hello World");
    Console.WriteLine(reversed);
    ```

---

## Code Snippets

### Main Program
```csharp
static void Main(string[] args)
{
    // Non-static method example
    Program program = new Program();
    program.Greeting("Devrim");

    // Static methods examples
    decimal nettoIncome = NettoIncome(34333m, 0.3m);
    Console.WriteLine("Monthly Income: " + nettoIncome);
    Console.WriteLine("Yearly Income: " + (nettoIncome * 12));

    SumOfNumbers(0, 200);

    string reversedText = reverseText("I am sure you will be great programmers");
    Console.WriteLine(reversedText);
}
```

### Methods
#### Greeting Method
```csharp
public void Greeting(string personName)
{
    Console.WriteLine($"Hello, my name is {personName}");
}
```

#### Netto Income
```csharp
public static decimal NettoIncome(decimal bruttoIncome, decimal taxRate)
{
    return bruttoIncome * (1 - taxRate);
}
```

#### Sum of Numbers
```csharp
public static void SumOfNumbers(int startNumber, int endNumber)
{
    int sum = 0;
    for (int i = startNumber; i <= endNumber; i++)
    {
        sum += i;
    }
    Console.WriteLine($"The sum of numbers between {startNumber} and {endNumber} is {sum}");
}
```

#### Reverse Text
```csharp
public static string reverseText(string anyText)
{
    return new string(anyText.Reverse().ToArray());
}
```

---

## Learning Outcomes
By the end of this lesson, students were able to:
- Understand the differences between static and non-static methods.
- Write and use methods effectively to perform calculations and manipulations.
- Apply modular programming principles to solve problems.

---

## Next Steps
- Practice creating more static and non-static methods.
- Experiment with different ways to manipulate data and use methods to solve problems.
- Explore more advanced C# concepts like classes, inheritance, and interfaces.
