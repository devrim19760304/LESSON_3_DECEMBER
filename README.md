# LESSON 3/12/2024 C# BASIC CONCEPTS 


# Lesson 3-1: Understanding Arrays and Loops in C#

## Overview
In this lesson, we focused on working with arrays in C# and using loops to iterate through them. We also explored how to create and manipulate arrays without altering the original data by using the **`Clone`** method.

---

## Key Concepts

### 1. Iterating Through Arrays
- **Numerical Array**:
    - Declared and initialized an array of integers.
    - Used a `foreach` loop to iterate through and print each value.
    - Calculated the total sum of the array elements.

    Example:
    ```csharp
    int[] numberArray = { 1, 2, 3, 4, 6, 8, 4, 8 };
    int totalSum = 0;

    foreach (var value in numberArray)
    {
        totalSum += value;
        Console.WriteLine(value);
    }
    Console.WriteLine($"Total Sum of Array: {totalSum}");
    ```

- **String Array**:
    - Initialized a string array with names of fruits.
    - Used a `for` loop with the `Length` property to iterate through the array.

    Example:
    ```csharp
    string[] fruits = { "Lemon", "Apple", "Kiwi", "Fig" };
    for (var i = 0; i < fruits.Length; i++)
    {
        Console.WriteLine(fruits[i]);
    }
    ```

---

### 2. Cloning and Sorting Arrays
- **Array Cloning**:
    - Demonstrated how to use the `Clone()` method to create a new array, avoiding issues with shared memory addresses between arrays.
    - Sorted the cloned array without altering the original array.

    Example:
    ```csharp
    string[] sortedFruitsArray = (string[])fruits.Clone();
    Array.Sort(sortedFruitsArray);
    ```

- **Output Comparison**:
    - Printed both the original and sorted arrays side by side.

    Example:
    ```csharp
    for (var i = 0; i < sortedFruitsArray.Length; i++)
    {
        Console.WriteLine(sortedFruitsArray[i] + "-----" + fruits[i]);
    }
    ```

---

### 3. Alternative Looping Methods
- Highlighted the simplicity of using `foreach` for looping through arrays compared to `for`.

    Example:
    ```csharp
    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
    ```

---

## Learning Outcomes
By the end of this lesson, students learned:
- How to declare and initialize arrays.
- Techniques for looping through arrays using `for` and `foreach`.
- The importance of using the `Clone` method for creating independent copies of arrays.
- How to sort arrays without affecting the original data.

---

## Next Steps
- Practice creating arrays of different data types and iterating through them.
- Experiment with other array methods like `Reverse`, `Find`, and `Resize`.
- Understand how arrays compare with other data structures like `List<T>` in C#.




# Lesson 3-2: Using Loops to Calculate Sums in C#

## Overview
In this tutorial, we explored how to use a `for` loop to calculate the sum of numbers between a start and an end value. We kept the implementation simple and did not use separate methods, focusing on foundational programming concepts.

---

## Key Concepts

### 1. Summing Numbers in a Range
- Used a `for` loop to iterate through a range of numbers.
- Accumulated the sum using a variable initialized outside the loop.

    Example:
    ```csharp
    int startNumber = 0;
    int endNumber = 100;
    int sum = 0;

    for (int i = startNumber; i <= endNumber; i++)
    {
        sum += i;
    }

    Console.WriteLine($"The sum of numbers between {startNumber} and {endNumber} is {sum}");
    ```

---

### 2. Formatting Output
- Demonstrated the use of a verbatim interpolated string (`$@`) for cleaner and more readable output formatting.

    Example:
    ```csharp
    string sumText = $@"
    The sum of numbers
    between {startNumber} and {endNumber}
    The result: {sum}
    ";
    Console.WriteLine(sumText);
    ```

---

### 3. Summing Odd Numbers
- Expanded the task by calculating the sum of odd numbers in the same range.
- Added a condition (`if (i % 2 == 1)`) within the loop to filter for odd numbers.

    Example:
    ```csharp
    int acc = 0;
    for (int i = startNumber; i <= endNumber; i++)
    {
        if (i % 2 == 1)
        {
            acc += i;
        }
    }
    Console.WriteLine($"The sum of odd numbers between {startNumber} and {endNumber} is {acc}");
    ```

---

## Learning Outcomes
By the end of this lesson, students were able to:
- Write and understand basic `for` loops.
- Use conditional logic inside loops to filter values (e.g., odd numbers).
- Format and display results using string interpolation.

---

## Next Steps
- Practice using loops for more complex arithmetic problems.
- Experiment with finding sums of even numbers, prime numbers, or numbers divisible by a given factor.
- Explore alternative loop structures like `while` and `do-while`.





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





# Lesson 3-4: Binary Number Conversion in C#

## Overview
In this lesson, we explore how to create a method that converts a decimal number into its binary representation. This is a practical and useful application of loops, conditionals, and string manipulation.

---

## Key Concepts

### 1. Binary Conversion
- Created a method (`BinaryConverter`) to convert a decimal number to a binary number.
- Used a `while` loop to repeatedly divide the number by 2 and collect the binary digits.
- Reversed the binary digits to get the correct binary representation.

    Example:
    ```csharp
    public static void BinaryConverter(int anyNumber)
    {
        string binaryText = "";

        while (anyNumber != 0)
        {
            if (anyNumber % 2 == 0)
            {
                binaryText += "0";
            }
            else
            {
                binaryText += "1";
            }
            anyNumber = anyNumber / 2;
        }

        // Reverse the text to get the proper binary number
        binaryText = new string(binaryText.Reverse().ToArray());
        Console.WriteLine($"The binary representation is: {binaryText}");
    }
    ```

---

### 2. Extra Useful Application
This binary converter method is highly practical and can be adapted for other purposes, such as:
- Converting numbers to other numeral systems (e.g., octal, hexadecimal).
- Learning how binary numbers are used in computer systems.

---

## Learning Outcomes
By the end of this lesson, students were able to:
- Understand how to use loops and conditionals for iterative calculations.
- Apply string manipulation techniques to format and display results.
- Develop an appreciation for binary representation in computing.

---

## Next Steps
- Extend the `BinaryConverter` method to handle larger numbers.
- Write similar methods to convert binary numbers back to decimal.
- Explore how binary is used in applications like bit manipulation and encryption.

