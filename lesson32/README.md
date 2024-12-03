
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

